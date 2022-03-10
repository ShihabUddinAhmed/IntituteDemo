using Institute.Models;
using Microsoft.EntityFrameworkCore;


namespace Institute.DBContext
{
    public class StudentContext : DbContext
    {
        public StudentContext() { }
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasIndex(e => e.IdentificationNumber)
                .IsUnique();
            modelBuilder.Entity<Student>()
                .HasIndex(e => e.Email)
                .IsUnique();
            modelBuilder.Entity<Student>()
                .Property(e => e.IsActive)
                .HasDefaultValue(true);

        }
        public DbSet<Student> Student { get; set; }

    }
}
