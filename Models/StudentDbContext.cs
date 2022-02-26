using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> Options) : base(Options) { }
        public DbSet<Emp> Emps { get; set; }
    }
}
