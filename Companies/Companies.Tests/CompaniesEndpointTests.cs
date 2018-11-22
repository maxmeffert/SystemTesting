using Moq;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using Companies.Core.Data;
using Companies.Core.Endpoints;
using Companies.Core.Model;
using Companies.Core.Sorting;

namespace Companies.Tests
{

    [TestFixture]
    public class CompaniesEndpointTests
    {
        private CompaniesEndpoint _cut;
        private Mock<IDataContext> _dataContextMock;
        private Mock<ICompaniesSorter> _companiesSorterMock;

        [SetUp]
        public void Setup()
        {
            _dataContextMock = new Mock<IDataContext>();
            _companiesSorterMock = new Mock<ICompaniesSorter>();
            _cut = new CompaniesEndpoint(_dataContextMock.Object, _companiesSorterMock.Object);
        }

        [Test]
        public void ReturnsSortedCompanies()
        {
            var companies = new Company[5].Select(_ => new Company());
            var sortedCompanies = new Company[5].Select(_ => new Company());

            Assert.AreNotSame(companies, sortedCompanies);

            _dataContextMock
                .Setup(m => m.Companies)
                .Returns(companies);

            _companiesSorterMock
                .Setup(m => m.Sort(companies))
                .Returns(sortedCompanies);

            var result = _cut.Get();

            Assert.AreSame(sortedCompanies, result);
        }
    }
}