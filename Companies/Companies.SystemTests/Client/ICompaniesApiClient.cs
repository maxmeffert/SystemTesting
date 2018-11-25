using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using Companies.Core;
using Companies.Core.Model;

namespace Companies.SystemTests.Client
{
    public interface ICompaniesApiClient
    {
        Task<HttpResponseMessage> GetValuesResponse();
        Task<string[]> GetValues();

        Task<HttpResponseMessage> GetCompaniesResponse();
        Task<IEnumerable<Company>> GetCompanies();

        Task<HttpResponseMessage> GetDepartmentsResponse();
        Task<IEnumerable<Department>> GetDepartments();
    }
}