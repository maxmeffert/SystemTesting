using System.Collections.Generic;
using System.Linq;
using Companies.Core.Model;

namespace Companies.Core.Sorting
{
    public class DepartmentsSorter : IDepartmentsSorter
    {
        private readonly INamedEntitySorter _namedEntitySorter;

        public DepartmentsSorter(INamedEntitySorter namedEntitySorter)
        {
            _namedEntitySorter = namedEntitySorter;
        }

        public IEnumerable<Department> Sort(IEnumerable<Department> departments)
        {
            return _namedEntitySorter.Sort(departments).Cast<Department>();
        }
    }
}