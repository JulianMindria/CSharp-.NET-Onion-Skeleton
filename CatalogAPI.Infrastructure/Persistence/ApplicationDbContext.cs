using CatalogAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogAPI.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> Brands { get; set; }
        public DbSet<ProductCategory> Categories { get; set; }
        public DbSet<ProductType> Types { get; set; }
        public DbSet<ProductImage> Images { get; set; }
        public DbSet<PSubDetail> SubDetails { get; set; }
        public DbSet<PSubDetailType> SubDetailTypes { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Product>()
        //        .HasOne(p => p.Brand)
        //        .WithMany(b => b.Products)
        //        .HasForeignKey(p => p.BrandId)
        //        .OnDelete(DeleteBehavior.Cascade);  

        //    modelBuilder.Entity<Product>()
        //        .HasOne(p => p.Category)
        //        .WithMany(c => c.Products)
        //        .HasForeignKey(p => p.CategoryId)
        //        .OnDelete(DeleteBehavior.Restrict);  

        //    modelBuilder.Entity<Product>()
        //        .HasOne(p => p.Type)
        //        .WithMany(t => t.Products)
        //        .HasForeignKey(p => p.TypeId)
        //        .OnDelete(DeleteBehavior.Restrict);  

        //    modelBuilder.Entity<SubDetail>()
        //        .HasOne(sd => sd.Product)
        //        .WithMany(p => p.SubDetails)
        //        .HasForeignKey(sd => sd.ProductId)
        //        .OnDelete(DeleteBehavior.Cascade);  

        //    modelBuilder.Entity<SubDetail>()
        //        .HasOne(sd => sd.Type)
        //        .WithMany(t => t.SubDetails)
        //        .HasForeignKey(sd => sd.TypeId)
        //        .OnDelete(DeleteBehavior.Restrict); 

        //    modelBuilder.Entity<Images>()
        //        .HasOne(i => i.Product)
        //        .WithMany(p => p.Images)
        //        .HasForeignKey(i => i.ProductId)
        //        .OnDelete(DeleteBehavior.Cascade); 
        //}
    }
}
