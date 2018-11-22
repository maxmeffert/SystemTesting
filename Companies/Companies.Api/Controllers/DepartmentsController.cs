using System.Collections.Generic;
using System.Linq;
using Companies.Core.Endpoints;
using Companies.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace Companies.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentsEndpoint _departmentsEndpoint;

        public DepartmentsController(IDepartmentsEndpoint departmentsEndpoint)
        {
            _departmentsEndpoint = departmentsEndpoint;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Department>> Get()
        {
            return _departmentsEndpoint.Get().ToArray();
        }
    }
}