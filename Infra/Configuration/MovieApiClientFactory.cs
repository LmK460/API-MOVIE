using RestSharp;

namespace Infra.Configuration
{
    public class MovieApiClientFactory
    {
        public RestClient RestClient { get; }
        public string ApiKey { get; }

        public MovieApiClientFactory(string baseUrl, string apikey)
        {
            RestClient = new RestClient(baseUrl) ?? throw new ArgumentNullException(nameof(baseUrl));
            ApiKey = apikey;
        }
    }
}
