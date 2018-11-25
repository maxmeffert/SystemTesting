
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Companies.Api;

namespace Companies.SystemTests.Client
{
    public class CompaniesApiClientFactory : ICompaniesApiClientFactory
    {
        private const string EnvironmentName = "SystemTests";
        public ICompaniesApiClient CreateClient()
        {
            var builder = CreateWebHostBuilder();
            var server = CreateTestServer(builder);
            var client = server.CreateClient();

            return new CompaniesApiClient(client);
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
}