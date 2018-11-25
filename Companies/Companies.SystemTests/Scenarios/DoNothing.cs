using System;
using System.Threading;
using System.Threading.Tasks;

namespace Companies.SystemTests.Scenarios
{
    public class DoNothing : BaseSystemTestCase
    {
        public override Task Given()
        {
            return Task.FromResult(true);
        }

        public override Task When()
        {
            return Task.FromResult(true);
        }

        public override Task Then()
        {
            return Task.FromResult(true);
        }
    }
}