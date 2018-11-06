using Companies.SystemTests.Client;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Companies.SystemTests
{
    [TestFixture]
    public class SystemTestRunner
    {
        private ICompaniesApiClientFactory _clientFactory;

        [SetUp]
        public void SetUp()
        {
            _clientFactory = new CompaniesApiClientFactory();
        }

        [Test]
        [TestCaseSource(typeof(SystemTestCases), nameof(SystemTestCases.All))]
        public async Task Run(ISystemTestCase systemTestCase)
        {
            systemTestCase.Client = _clientFactory.CreateClient();

            await systemTestCase.Given();
            await systemTestCase.When();
            await systemTestCase.Then();
        }
    }
}