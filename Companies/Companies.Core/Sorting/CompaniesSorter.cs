using System.Collections.Generic;
using System.Linq;
using Companies.Core.Model;

namespace Companies.Core.Sorting
{
    public class CompaniesSorter : ICompaniesSorter
    {
        private readonly INamedEntitySorter _namedEntitySorter;

        public CompaniesSorter(INamedEntitySorter namedEntitySorter)
        {
            _namedEntitySorter = namedEntitySorter;
        }

        public IEnumerable<Company> Sort(IEnumerable<Company> companies)
        {
            return _namedEntitySorter.Sort(companies).Cast<Company>();
        }
    }
}