using Microsoft.EntityFrameworkCore;

namespace UnitOfWork.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ClassDb1> ClassDb1s { get; set; }
        public DbSet<ClassDb2> ClassDb2s { get; set; }
        public DbSet<ClassDb3> ClassDb3s { get; set; }
        public DbSet<ClassDb4> ClassDb4s { get; set; }
        public DbSet<ClassDb5> ClassDb5s { get; set; }

    }
}
