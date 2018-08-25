using Microsoft.EntityFrameworkCore;

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

}