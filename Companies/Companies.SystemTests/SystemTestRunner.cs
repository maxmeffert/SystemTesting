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
        private TestClientFactory _testClientFactory;

        [SetUp]
        public void SetUp()
        {
            _testClientFactory = new TestClientFactory();
        }

        [Test]
        [TestCaseSource(typeof(SystemTestCases), nameof(SystemTestCases.All))]
        public async Task Run(ISystemTestCase systemTestCase)
        {
            systemTestCase.Client = _testClientFactory.CreateTestClient();

            await systemTestCase.Given();
            await systemTestCase.When();
            await systemTestCase.Then();
        }
    }
}