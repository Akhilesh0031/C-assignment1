using Employee_Assign1.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Assign1.Shared
{
    public class DBApplicationContext : DbContext
    {
        

        public DBApplicationContext(DbContextOptions<DBApplicationContext> option) : base(option)
        { 
        }

        public DbSet<Employee> employees { get; set; }
    }
}
