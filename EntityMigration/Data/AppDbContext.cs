using EntityMigration.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityMigration.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<VideoValentine> Videos { get; set; }
        public DbSet<Valentine> Valentines { get; set; }
        public DbSet<Experts> Experts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCards> BlogCards { get; set; }
        public DbSet<InstaCarousel> InstaCarousels { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Setup> Setups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Setup>().HasData(
                new Setup
                {
                    Id=1,
                    Load=4,
                    HomeProductTake=8,
                }
              );
        }


    }
}
