using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is Title of eShopSolotion" },
                new AppConfig() { Key = "HomeKeyWord", Value = "This is Keyword of eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is Description of eShopSolution" }
                );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOrder = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Enums.Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOrder = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Enums.Status.Active,
                 });
            modelBuilder.Entity<CategoryTranslation>().HasData(

            new CategoryTranslation()
            {
                Id = 1,
                CategoryId = 1,
                Name = "Áo Sơ Mi Nam",
                LanguageId = "vi-VN",
                SeoAlias = "ao-so-mi-nam",
                SeoDescription = " Áo sơ mi nam đẹp trai",
                SeoTitle = "Áo sơ mi nam đẹp trai"
            },
            new CategoryTranslation()
            {
                Id = 2,
                CategoryId = 1,
                Name = "Man in Shirt",
                LanguageId = "en-US",
                SeoAlias = "man-in-shirt",
                SeoDescription = "Man In Shirt So Hot",
                SeoTitle = "Man In Shirt So Hot"
            },
            new CategoryTranslation()
            {
                Id = 3,
                CategoryId = 2,
                Name = "Áo Sơ Mi Nam",
                LanguageId = "vi-VN",
                SeoAlias = "ao-so-mi-nam",
                SeoDescription = " Áo sơ mi nam đẹp trai",
                SeoTitle = "Áo sơ mi nam đẹp trai"
            },
            new CategoryTranslation()
            {
                Id = 4,
                CategoryId = 2,
                Name = "Man in Shirt",
                LanguageId = "en-US",
                SeoAlias = "man-in-shirt",
                SeoDescription = "Man In Shirt So Hot",
                SeoTitle = "Man In Shirt So Hot"
            });


            modelBuilder.Entity<Product>().HasData(
                       new Product()
                       {
                           Id = 1,
                           DateCreated = DateTime.Now,
                           OriginalPrice = 500000,
                           Price = 10001,
                           Stock = 0,
                           ViewCount = 0,
                       });

            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Man in Shirt office",
                    LanguageId = "en-US",
                    SeoAlias = "man-in-shirt-office",
                    SeoDescription = "Man in Shirt office",
                    SeoTitle = "Man in Shirt office",
                    Details = "Description of products",
                    Description = "Description of products"
                });
            modelBuilder.Entity<ProductInCategory>().HasData(
              new ProductInCategory() { ProductId = 1, CategoryId = 1 }
              );


            modelBuilder.Entity<Product>().HasData(
                       new Product()
                       {
                           Id = 2,
                           DateCreated = DateTime.Now,
                           OriginalPrice = 500000,
                           Price = 10001,
                           Stock = 0,
                           ViewCount = 0,
                       });

            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 2,
                    Name = "Man in Shirt office",
                    LanguageId = "en-US",
                    SeoAlias = "man-in-shirt-office",
                    SeoDescription = "Man in Shirt office",
                    SeoTitle = "Man in Shirt office",
                    Details = "Description of products",
                    Description = "Description of products"
                });
            modelBuilder.Entity<ProductInCategory>().HasData(
              new ProductInCategory() { ProductId = 2, CategoryId = 2 }
              );

        }
    }
}

