using Companies.SystemTests.Client;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Companies.SystemTests
{
    public abstract class BaseSystemTestCase : ISystemTestCase
    {
        public ICompaniesApiClient Client { get; set; }
        public abstract Task Given();
        public abstract Task When();
        public abstract Task Then();
    }
}