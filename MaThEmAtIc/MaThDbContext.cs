using MaThEmAtIc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MaThEmAtIc
{
    public class MaThDbContext : DbContext
    {
        public MaThDbContext(DbContextOptions<MaThDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }
    }

    public class MaThDbContextFactory : IDesignTimeDbContextFactory<MaThDbContext>
    {
        public MaThDbContext CreateDbContext(string[] args) 
        {
            var optionsBuilder = new DbContextOptionsBuilder<MaThDbContext>();

            optionsBuilder.UseSqlServer(@"Server=DESKTOP-RR0CBRF\LALAPEN;Database=FromMathTeach;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=True", b => b.MigrationsAssembly("MaThEmAtIc"));

            return new MaThDbContext(optionsBuilder.Options);
        }
    }
}
