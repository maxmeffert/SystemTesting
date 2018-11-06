using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace Companies.SystemTests.Client
{
    public interface ICompaniesApiClient
    {
        Task<HttpResponseMessage> GetValuesResponse();
    }
}