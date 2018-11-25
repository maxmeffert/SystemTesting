using System.Collections.Generic;
using Companies.Core.Model;

namespace Companies.Core.Data
{
    public class DataContext : IDataContext
    {
        public IEnumerable<Company> Companies { get; } = new [] {
            new Company
            {
                Id = 1,
                Name = "Facebook"
            },
            new Company
            {
                Id = 2,
                Name = "Apple"
            },
            new Company
            {
                Id = 3,
                Name = "Amazon"
            },
            new Company
            {
                Id = 4,
                Name = "Netflix"
            },
            new Company
            {
                Id = 5,
                Name = "Google"
            }
        };

        public IEnumerable<Department> Departments { get; } = new [] {
            new Department
            {
                Id = 1,
                Name = "Sales"
            },
            new Department
            {
                Id = 2,
                Name = "Humen Resources"
            },
            new Department
            {
                Id = 3,
                Name = "IT-Support"
            },
            new Department
            {
                Id = 4,
                Name = "Research and Development"
            }
        };
    }
}