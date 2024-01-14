
using Connector.Models.Entities;

namespace Connector.Repo
{
    public interface ICqcRepoService
    {
        Task<HttpResponseMessage> GetProvider(string id);
        Task<Provider?> GetProviderFromByte(HttpResponseMessage httpResponseMessage);
        Task<HttpResponseMessage> GetProviders();
    }
}