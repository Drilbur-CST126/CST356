using Microsoft.EntityFrameworkCore;

namespace Databases
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)         
        {         
        }
        
        public DbSet<Student> Student { get; set; }
    }
}