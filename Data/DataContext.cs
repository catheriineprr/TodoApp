using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
    }
}
