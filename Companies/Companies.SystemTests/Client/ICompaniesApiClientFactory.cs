namespace Companies.SystemTests.Client
{
    public interface ICompaniesApiClientFactory
    {
        ICompaniesApiClient CreateClient();
    }
}