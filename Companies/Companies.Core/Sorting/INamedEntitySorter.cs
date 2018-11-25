using System.Collections.Generic;
using Companies.Core.Model;

namespace Companies.Core.Sorting
{
    public interface INamedEntitySorter
    {
        IEnumerable<NamedEntity> Sort(IEnumerable<NamedEntity> namedEntities);
    }
}
