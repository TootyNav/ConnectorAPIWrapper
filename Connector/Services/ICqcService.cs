using Connector.Models.Entities;

namespace Connector.Services
{
    public interface ICqcService
    {
        Task<Provider?> GetProvider(string id);
    }
}