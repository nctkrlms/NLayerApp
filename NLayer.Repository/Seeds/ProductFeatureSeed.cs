using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                new ProductFeature
                {
                    Id = 1,
                    ProductId = 1,
                    Color = "Brown",
                    Height = 10,
                    Width = 5,
                },
                new ProductFeature
                {
                    Id = 2,
                    ProductId = 2,
                    Color = "Yellow",
                    Height = 10,
                    Width = 5,
                },
                new ProductFeature
                {
                    Id = 3,
                    ProductId = 3,
                    Color = "Orange",
                    Height = 10,
                    Width = 5,
                },
                new ProductFeature
                {
                    Id = 4,
                    ProductId = 3,
                    Color = "Black",
                    Height = 10,
                    Width = 5,
                }

                );
        }
    }
}
