using System.Collections.Generic;
using System.Linq;
using Companies.Core.Model;

namespace Companies.Core.Sorting
{
    public class NamedEntitySorter : INamedEntitySorter
    {
        public IEnumerable<NamedEntity> Sort(IEnumerable<NamedEntity> namedEntities)
        {
            return namedEntities.OrderByDescending(namedEntity => namedEntity.Name); // provokes a regression
            // return namedEntities.OrderBy(namedEntity => namedEntity.Name);
        }
    }
}
