using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using Companies.Core.Model;

namespace Companies.SystemTests.Scenarios
{
    public class GetDepartmentsIsOrdertedByName : BaseSystemTestCase
    {
        private IEnumerable<Department> _departments;
        public override Task Given()
        {
            return Task.FromResult(true);
        }

        public override async Task When()
        {
            _departments = await Client.GetDepartments();
        }

        public override async Task Then()
        { 
            Assert.IsNotNull(_departments);
            Assert.IsNotEmpty(_departments);
            Assert.That(_departments, Is.Ordered.By("Name").Ascending);
            await Task.Delay(0);
        }
    }
}