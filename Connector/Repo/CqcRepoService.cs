using Connector.Models.Entities;
using System.Text.Json;

namespace Connector.Repo
{
    public class CqcRepoService : ICqcRepoService
    {
        readonly IHttpClientFactory _httpClientFactory;
        private const string _httpName = "cqc";
        private const string _url = "public/v1/providers/";

        public CqcRepoService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<HttpResponseMessage> GetProviders()
        {
            var httpClient = _httpClientFactory.CreateClient(_httpName);
            return await httpClient.GetAsync(_url);
        }

        public async Task<HttpResponseMessage> GetProvider(string id)
        {
            var httpClient = _httpClientFactory.CreateClient(_httpName);
            return await httpClient.GetAsync(_url + id);
        }

        public async Task<Provider?> GetProviderFromByte(HttpResponseMessage httpResponseMessage)
        {
            var jsonString = await httpResponseMessage.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

            var provider = JsonSerializer.Deserialize<Provider>(jsonString, options);

            return provider;
        }


    }
}
