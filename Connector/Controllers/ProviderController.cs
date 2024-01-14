
using Microsoft.AspNetCore.Mvc;
using Connector.Models.Entities;
using Connector.Repo;
using Connector.Services;
namespace Connector.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProviderController : ControllerBase
{
    private readonly ICqcRepoService _cqcRepoService;
    private readonly ICqcService _CqcService;

    public ProviderController(ICqcRepoService cqcRepoService, ICqcService cqcService)
    {
        _cqcRepoService = cqcRepoService;
        _CqcService = cqcService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProviderSummary>>> GetProvider()
    {
        var providers = await _CqcService.GetProviderSummary();

        return providers == null ? NotFound() : Ok(providers);
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Provider>> GetProvider(string id)
    {
        var provider = await _CqcService.GetProvider(id);

        return provider == null ? NotFound() : Ok(provider);
    }

}
