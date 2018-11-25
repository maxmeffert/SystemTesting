using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Companies.Core;
using Companies.Core.Endpoints;
using Companies.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace Companies.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompaniesEndpoint _companiesEndpoint;

        public CompaniesController(ICompaniesEndpoint companiesEndpoint)
        {
            _companiesEndpoint = companiesEndpoint;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Company>> Get()
        {
            return _companiesEndpoint.Get().ToArray();
        }
    }
}