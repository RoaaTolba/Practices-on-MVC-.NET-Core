using Microsoft.EntityFrameworkCore;

namespace AssigmentMVCday2.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Course> courses { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<CrsResult> CrsResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-LVA4E65\\MSSQLSERVER01;Integrated Security=True;Database=ITIday2;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<CrsResult>()
        //        .HasKey(k => new { k.trainee_id, k.crs_id });
        //}
    }
}
