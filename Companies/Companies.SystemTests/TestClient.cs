using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Companies.Api;

namespace Companies.SystemTests
{
    public class TestClientFactory
    {
        private const string EnvironmentName = "SystemTests";
        public TestClient CreateTestClient()
        {
            var builder = CreateWebHostBuilder();
            var server = CreateTestServer(builder);
            var client = server.CreateClient();

            return new TestClient(client);
        }

        private static IWebHostBuilder CreateWebHostBuilder()
        {
            return new WebHostBuilder()
                .UseEnvironment(EnvironmentName)
                .UseStartup<Startup>();
        }

        private static TestServer CreateTestServer(IWebHostBuilder webHostBuilder)
        {
            return new TestServer(webHostBuilder);
        }
    }

    public class TestClient
    {
        private readonly HttpClient _httpClient;

        public TestClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<HttpResponseMessage> GetValuesResponse()
        {
            return _httpClient.GetAsync("/api/values");
        }
    }
}