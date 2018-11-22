using System.Collections.Generic;
using Companies.Core.Data;
using Companies.Core.Model;
using Companies.Core.Sorting;

namespace Companies.Core.Endpoints
{
    public class CompaniesEndpoint : ICompaniesEndpoint
    {   
        private readonly IDataContext _dataContext;
        private readonly ICompaniesSorter  _companiesSorter;

        public CompaniesEndpoint(IDataContext dataContext, ICompaniesSorter companiesSorter)
        {
            _dataContext = dataContext;
            _companiesSorter = companiesSorter;
        }

        public IEnumerable<Company> Get()
        {            
            return _companiesSorter.Sort(_dataContext.Companies);
        }
    }
}