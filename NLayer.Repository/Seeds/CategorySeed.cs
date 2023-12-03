using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Mamalar", CreatedDate = DateTime.Now }, 
                new Category { Id = 2, Name = "Tasmalar", CreatedDate = DateTime.Now },
                new Category { Id = 3, Name = "Oyuncaklar", CreatedDate = DateTime.Now });
        }
    }
}
