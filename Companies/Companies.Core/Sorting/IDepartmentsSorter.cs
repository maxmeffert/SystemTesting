using System.Collections.Generic;
using Companies.Core.Model;

namespace Companies.Core.Sorting
{
    public interface IDepartmentsSorter
    {
         IEnumerable<Department> Sort(IEnumerable<Department> departments);
    }
}