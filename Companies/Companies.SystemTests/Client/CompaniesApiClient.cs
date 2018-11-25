using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Companies.Core;
using Companies.Core.Model;

namespace Companies.SystemTests.Client
{

    public class CompaniesApiClient : ICompaniesApiClient
    {
        private readonly HttpClient _httpClient;

        public CompaniesApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Company>> GetCompanies()
        {
            return await DesecializeResponseAsync<IEnumerable<Company>>(GetDepartmentsResponse());
        }

        public Task<HttpResponseMessage> GetCompaniesResponse()
        {
            return _httpClient.GetAsync("/api/companies");
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await DesecializeResponseAsync<IEnumerable<Department>>(GetDepartmentsResponse());
        }

        public Task<HttpResponseMessage> GetDepartmentsResponse()
        {
            return _httpClient.GetAsync("/api/departments");
        }

        public async Task<string[]> GetValues()
        {
            var response = await GetValuesResponse();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<string[]>(content);
        }

        public Task<HttpResponseMessage> GetValuesResponse()
        {
            return _httpClient.GetAsync("/api/values");
        }

        private static async Task<TResult> DesecializeResponseAsync<TResult>(Task<HttpResponseMessage> responseTask)
        {
            var response = await responseTask;
            return await DesecializeResponseAsync<TResult>(await responseTask);
        }

        private static async Task<TResult> DesecializeResponseAsync<TResult>(HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResult>(content);
        }
    }
}