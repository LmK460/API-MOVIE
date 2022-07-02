using RestSharp;

namespace Infra.Configuration
{
    public class ApiClientFactory
    {
        public RestClient RestClient { get; }

        public ApiClientFactory(string baseUrl)
        {
            RestClient = new RestClient(baseUrl) ?? throw new ArgumentNullException(nameof(baseUrl));
            RestClient.AddDefaultHeader("Content-Type", "application / json");
            RestClient.AddDefaultHeader("Accept", "application/json");
        }
    }
}
