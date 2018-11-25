using System.Collections.Generic;
using Companies.Core.Model;

namespace Companies.Core.Sorting
{
    public interface ICompaniesSorter
    {
        IEnumerable<Company> Sort(IEnumerable<Company> companies);
    }
}