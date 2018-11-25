using Moq;
using NUnit.Framework;
using System.Linq;
using Companies.Core.Model;
using Companies.Core.Sorting;

namespace Companies.Tests
{
    [TestFixture]
    public class DepartmentsSorterTests
    {
        private DepartmentsSorter _cut;
        private Mock<INamedEntitySorter> _namedEntitySorterMock;

        [SetUp]
        public void Setup()
        {
            _namedEntitySorterMock = new Mock<INamedEntitySorter>();
            _cut = new DepartmentsSorter(_namedEntitySorterMock.Object);
        }

        [Test]
        public void SortsByNameAcending()
        {
            var departments = new Department[5].Select(_ => new Department());
            var sortedDepartments = new Department[5].Select(_ => new Department());

            Assert.AreNotSame(departments, sortedDepartments);

            _namedEntitySorterMock
                .Setup(m => m.Sort(departments))
                .Returns(sortedDepartments);

            var result = _cut.Sort(departments);

            Assert.AreSame(sortedDepartments, result);
        }
    }
}