using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configuration
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(x => new { x.CategoryId, x.ProductId });
            builder.ToTable("ProductInCategories");

            builder.HasOne(t => t.Product)
                .WithMany(y => y.ProductInCategories)
                .HasForeignKey(u => u.ProductId);


            builder.HasOne(t => t.Category)
                .WithMany(y => y.ProductInCategories)
                .HasForeignKey(u => u.CategoryId);


        }
    }
}
