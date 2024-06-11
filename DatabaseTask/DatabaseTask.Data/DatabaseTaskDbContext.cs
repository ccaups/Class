using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }
        public DbSet<Class> Class { get; set; }
        public DbSet<FoodCoupon> FoodCoupons { get; set; }
        public DbSet<GroupLeader> GroupLeaders { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
