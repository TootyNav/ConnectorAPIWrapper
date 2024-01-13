
namespace Connector.Repo
{
    public interface ICqcRepoService
    {
        Task<HttpResponseMessage> GetProvider(int id);
        Task<HttpResponseMessage> GetProviders();
    }
}