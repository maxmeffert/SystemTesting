using System.Collections.Generic;
using Companies.Core.Data;
using Companies.Core.Model;
using Companies.Core.Sorting;

namespace Companies.Core.Endpoints
{
    public class DepartmentsEndpoint : IDepartmentsEndpoint
    {
        private readonly IDataContext _dataContext;
        private readonly IDepartmentsSorter _departmentsSorter;

        public DepartmentsEndpoint(IDataContext dataContext, IDepartmentsSorter departmentsSorter)
        {
            _dataContext = dataContext;
            _departmentsSorter = departmentsSorter;
        }
        public IEnumerable<Department> Get()
        {
            return _departmentsSorter.Sort(_dataContext.Departments);
        }
    }
}