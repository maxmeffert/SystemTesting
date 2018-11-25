using Moq;
using NUnit.Framework;
using System.Linq;
using Companies.Core.Data;
using Companies.Core.Endpoints;
using Companies.Core.Model;
using Companies.Core.Sorting;

namespace Companies.Tests
{
    [TestFixture]
    public class DepartmentsEndpointTests
    {
        private DepartmentsEndpoint _cut;
        private Mock<IDataContext> _dataContextMock;
        private Mock<IDepartmentsSorter> _departmentsSorterMock;

        [SetUp]
        public void Setup()
        {
            _dataContextMock = new Mock<IDataContext>();
            _departmentsSorterMock = new Mock<IDepartmentsSorter>();
            _cut = new DepartmentsEndpoint(_dataContextMock.Object, _departmentsSorterMock.Object);
        }

        [Test]
        public void ReturnsSortedCompanies()
        {
            var departments = new Department[5].Select(_ => new Department());
            var sortedDepartments = new Department[5].Select(_ => new Department());

            Assert.AreNotSame(departments, sortedDepartments);

            _dataContextMock
                .Setup(m => m.Departments)
                .Returns(departments);

            _departmentsSorterMock
                .Setup(m => m.Sort(departments))
                .Returns(sortedDepartments);

            var result = _cut.Get();

            Assert.AreSame(sortedDepartments, result);
        }
    }
}