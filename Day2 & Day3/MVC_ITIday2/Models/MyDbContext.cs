using Microsoft.EntityFrameworkCore;

namespace MVC_ITIday2.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(): base()
        {
            
        }
        public MyDbContext(DbContextOptions options):base(options) 
        {
            
        }
        public DbSet<Department> DepartmentSet { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Database=ITIdatabase;Data Source=DESKTOP-LVA4E65\\MSSQLSERVER01;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
