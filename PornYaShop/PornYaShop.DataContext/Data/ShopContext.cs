using Microsoft.EntityFrameworkCore;
using PornYaShop.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PornYaShop.DataContext.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
            this.Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Variants)
                .WithOne(pv => pv.Product)
                .HasForeignKey(pv => pv.ProductId);
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductVariant> ProductVariant { get; set; }

    }
}
