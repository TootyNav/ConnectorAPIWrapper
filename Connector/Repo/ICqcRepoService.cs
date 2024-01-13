
namespace Connector.Repo
{
    public interface ICqcRepoService
    {
        Task<HttpResponseMessage> GetProvider(string id);
        Task<HttpResponseMessage> GetProviders();
    }
}