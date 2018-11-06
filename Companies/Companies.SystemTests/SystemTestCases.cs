using System;
using System.Collections.Generic;
using Companies.SystemTests.Scenarios;

namespace Companies.SystemTests
{
    public static class SystemTestCases
    {
        public static IEnumerable<BaseSystemTestCase> All()
        {
            yield return new DoNothing();
            yield return new Scenario1();
        }
    }
}