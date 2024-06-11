using Microsoft.EntityFrameworkCore;
using DatabaseTask.Core.Domain; // Make sure you have this namespace

namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        // Your DbSet properties here:
        public DbSet<Class> Classes { get; set; }
        public DbSet<FoodCoupon> FoodCoupons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<GroupLeader> GroupLeaders { get; set; }

        // Constructor (for options)
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relationship configurations:
            modelBuilder.Entity<Class>()
                .HasOne(c => c.GroupLeader)
                .WithMany(gl => gl.Classes)
                .HasForeignKey(c => c.GroupLeaderID);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Class)
                .WithMany() // No navigation property in Class to its students
                .HasForeignKey(s => s.ClassCode);

            modelBuilder.Entity<FoodCoupon>()
                .HasOne(fc => fc.Student)
                .WithMany(s => s.FoodCoupons)
                .HasForeignKey(fc => fc.StudentID);

            // Additional configurations (e.g., indexes, seed data)
            // ...
        }
    }
}
