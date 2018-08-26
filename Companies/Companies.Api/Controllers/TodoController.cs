using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Companies.Api.Controllers {

    public class TodoItem {
        
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }

    public class TodoContext : DbContext {
        public TodoContext(DbContextOptions<TodoContext> options) 
            : base(options) 
        {
        }

        public DbSet<TodoItem> TodoItems {get; set;}
    }

    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase {

        private readonly TodoContext _todoContext;

        public TodoController(TodoContext todoContext) {
            _todoContext = todoContext;

            // _todoContext.TodoItems.Add(new TodoItem {
            //     Name = "asdf"
            // });
            // _todoContext.SaveChanges();
        }

        [HttpGet]
        public ActionResult<List<TodoItem>> GetAll() {
            return _todoContext.TodoItems.ToList();
        }
    }

}