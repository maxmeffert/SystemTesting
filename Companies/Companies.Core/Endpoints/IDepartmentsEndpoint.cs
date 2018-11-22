using System.Collections.Generic;
using Companies.Core.Model;

namespace Companies.Core.Endpoints
{
    public interface IDepartmentsEndpoint
    {
         IEnumerable<Department> Get();
    }
}