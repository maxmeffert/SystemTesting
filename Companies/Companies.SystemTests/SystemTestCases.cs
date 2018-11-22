using Companies.SystemTests.Scenarios;
using NUnit.Framework;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Companies.SystemTests
{
    public static class SystemTestCases
    {
        public static IEnumerable All()
        {
            return AllSystemTestCases().Select(CreateTestCaseData);
        }

        private static TestCaseData CreateTestCaseData(ISystemTestCase systemTestCase)
        {
            return new TestCaseData(systemTestCase)
            {
                TestName = CreateTestName(systemTestCase)
            };
        }

        private static string CreateTestName(ISystemTestCase systemTestCase)
        {
            return $"Scenario: {systemTestCase.GetType().Name}";
        }

        private static IEnumerable<ISystemTestCase> AllSystemTestCases()
        {
            yield return new DoNothing();
            yield return new GetCompaniesIsOrdertedByName();
            yield return new GetDepartmentsIsOrdertedByName();
        }

    }
}