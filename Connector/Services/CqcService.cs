using Connector.Data;
using Connector.Models.Entities;
using Connector.Repo;
using Microsoft.EntityFrameworkCore;

namespace Connector.Services;
public class CqcService : ICqcService
{
    private readonly ConnectorContext _context;
    private readonly ICqcRepoService _cqcRepoService;


    public CqcService(ConnectorContext context, ICqcRepoService cqcRepoService)
    {
        _context = context;
        _cqcRepoService = cqcRepoService;
    }

    public async Task<IEnumerable<ProviderSummary>?> GetProviderSummary()
    {
        var dbProviderSummary = _context.ProviderSummary;

        if (dbProviderSummary.Count() > 0)
            return dbProviderSummary;

        var httpResponseMessage = await _cqcRepoService.GetProviders();

        if (!httpResponseMessage.IsSuccessStatusCode)
            return null;

        var providers = await _cqcRepoService.GetProvidersFromByte(httpResponseMessage);

        if (providers is null)
            return null; // log error

        await AddProvidersToDb(providers);

        return providers;
    }

    public async Task<Provider?> GetProvider(string id)
    {
        var dbProvider = await _context.Provider.SingleOrDefaultAsync(x => x.ProviderId == id);

        var cacheTimeOut = DateTimeOffset.Now.AddDays(-30);
        if (dbProvider is null || dbProvider.CachedOnDate <= cacheTimeOut)
        {
            var httpResponseMessage = await _cqcRepoService.GetProvider(id);

            if (!httpResponseMessage.IsSuccessStatusCode)
                return null;

            var newProvider = await _cqcRepoService.GetProviderFromByte(httpResponseMessage);

            if (newProvider is null) 
                return null; // log error

            await UpdateProvider(newProvider, dbProvider);

            return newProvider;
        }

        return dbProvider;
    }

    private async Task UpdateProvider(Provider newProvider, Provider? oldProvider)
    {
        if (oldProvider is not null)
        {
            _context.Provider.Remove(oldProvider);
        }
        newProvider.CachedOnDate = DateTimeOffset.Now;
        await _context.Provider.AddAsync(newProvider);
        await _context.SaveChangesAsync();
    }

    private async Task AddProvidersToDb(IEnumerable<ProviderSummary> providers)
    {
        await _context.AddRangeAsync(providers);
    }
}

