using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Whiskas",
                    Price = 220,
                    Stock = 50,
                    CreatedDate = DateTime.Now,
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Whiskas2",
                    Price = 220,
                    Stock = 50,
                    CreatedDate = DateTime.Now,
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Tasma1",
                    Price = 220,
                    Stock = 50,
                    CreatedDate = DateTime.Now,
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Tasma1",
                    Price = 250,
                    Stock = 50,
                    CreatedDate = DateTime.Now,
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 3,
                    Name = "Oyuncak1",
                    Price = 500,
                    Stock = 50,
                    CreatedDate = DateTime.Now,
                }
                );
        }
    }
}
