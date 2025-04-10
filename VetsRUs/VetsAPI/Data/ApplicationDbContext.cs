using Microsoft.EntityFrameworkCore;
using VetsAPI.Models;

namespace VetsAPI.Data
{
    public class ApplicationDbContext
    {
        public class ApplicationDbConnect : DbContext
        {
            public ApplicationDbConnect(DbContextOptions<ApplicationDbConnect> options)
                : base(options)
            {

            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbConnect).Assembly);
                base.OnModelCreating(modelBuilder);
            }
            public DbSet<Cat> Cats { get; set; }
            public DbSet<Dog> Dogs { get; set; }
        }
    }
}
