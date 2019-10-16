using Microsoft.EntityFrameworkCore;

namespace SQL
{
    public class SchoolContext : DbContext
    {
        private const string connectionString = "Server=localhost;Database=KursElevCodeFirst;Trusted_Connection=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Grades> Grades { get; set; }
        public DbSet<Betygssgrad> Betygssgrad { get; set; }
        public DbSet<Fråga> Fråga { get; set; }
        public DbSet<Prov> Prov { get; set; }
        public DbSet<Provsvar> Provsvar { get; set; }
        public DbSet<Svar> Svar { get; set; }
        public DbSet<Svaralt> Svaralt { get; set; }
        public DbSet<Provresultat> Provresultat { get; set; }
        public DbSet<RättatSvar> RättatSvar { get; set; }
    }
}
