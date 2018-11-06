using NUnit.Framework;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Companies.Api;

namespace Companies.SystemTests.Scenarios
{
    public class Scenario1 : BaseSystemTestCase
    {
        private HttpResponseMessage _response;
        public override Task Given()
        {
            return Task.FromResult(true);
        }

        public override async Task When()
        {
            _response = await Client.GetValuesResponse();
            _response.EnsureSuccessStatusCode();
        }

        public override async Task Then()
        { 
            var result = await _response.Content.ReadAsStringAsync();
            Assert.AreEqual("[\"value1\",\"value2\",\"value3\"]", result);
        }
    }
}