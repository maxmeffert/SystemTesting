using System.Collections.Generic;
using Companies.Core.Model;

namespace Companies.Core.Data
{
    public interface IDataContext
    {
        IEnumerable<Company> Companies { get; }
        IEnumerable<Department> Departments { get; }
    }
}