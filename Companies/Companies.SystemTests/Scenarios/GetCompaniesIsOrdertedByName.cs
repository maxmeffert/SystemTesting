using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using Companies.Core.Model;

namespace Companies.SystemTests.Scenarios
{
    public class GetCompaniesIsOrdertedByName : BaseSystemTestCase
    {
        private IEnumerable<Company> _companies;
        public override Task Given()
        {
            return Task.FromResult(true);
        }

        public override async Task When()
        {
            _companies = await Client.GetCompanies();
        }

        public override async Task Then()
        { 
            Assert.IsNotNull(_companies);
            Assert.IsNotEmpty(_companies);
            Assert.That(_companies, Is.Ordered.By("Name").Ascending);
            await Task.Delay(0);
        }
    }
}