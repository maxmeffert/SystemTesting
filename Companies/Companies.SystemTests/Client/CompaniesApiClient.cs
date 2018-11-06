using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace Companies.SystemTests.Client
{

    public class CompaniesApiClient : ICompaniesApiClient
    {
        private readonly HttpClient _httpClient;

        public CompaniesApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<HttpResponseMessage> GetValuesResponse()
        {
            return _httpClient.GetAsync("/api/values");
        }
    }
}