using Microsoft.EntityFrameworkCore;
using NLayer.Core.Model;
using System.Reflection;

namespace NLayer.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
            {
                Id = 1,
                Color = "mavi",
                ProductId = 1,
                Height = 1,
                Width = 1

            }, new ProductFeature()
            {
                Id = 2,
                Color = "yesil",
                ProductId = 2,
                Height = 2,
                Width = 2

            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
