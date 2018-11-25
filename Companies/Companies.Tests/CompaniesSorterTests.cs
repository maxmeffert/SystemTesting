using Moq;
using NUnit.Framework;
using System.Linq;
using Companies.Core.Model;
using Companies.Core.Sorting;

namespace Companies.Tests
{
    [TestFixture]
    public class CompaniesSorterTests
    {
        private CompaniesSorter _cut;
        private Mock<INamedEntitySorter> _namedEntitySorterMock;

        [SetUp]
        public void Setup()
        {
            _namedEntitySorterMock = new Mock<INamedEntitySorter>();
            _cut = new CompaniesSorter(_namedEntitySorterMock.Object);
        }

        [Test]
        public void SortsByNameAcending()
        {
            var companies = new Company[5].Select(_ => new Company());
            var sortedCompanies = new Company[5].Select(_ => new Company());

            Assert.AreNotSame(companies, sortedCompanies);

            _namedEntitySorterMock
                .Setup(m => m.Sort(companies))
                .Returns(sortedCompanies);

            var result = _cut.Sort(companies);

            Assert.AreSame(sortedCompanies, result);
        }
    }
}