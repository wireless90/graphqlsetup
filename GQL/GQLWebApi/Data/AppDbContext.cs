using GQLWebApi.Data.Configurations;
using GQLWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GQLWebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions dbContextOptions) : base (dbContextOptions)    
        {
            
        }

        public DbSet<Platform>  Platforms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlatformConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
