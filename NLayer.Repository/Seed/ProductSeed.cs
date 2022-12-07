using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seed
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product {
            Id= 1,
            CategoryId= 1,
            Name="urun1",
            Price= 1,
            Stock= 1,
            CreateDate= DateTime.Now,            
            },
            new Product {
            Id= 2,
            CategoryId= 1,
            Name = "urun2",
            Price = 2,
            Stock= 2,
            CreateDate= DateTime.Now,            
            },
            new Product {
            Id= 3,
            CategoryId= 2,
            Name = "kitapurun3",
            Price = 3,
            Stock= 3,
            CreateDate= DateTime.Now,            
            },
            new Product {
            Id= 4,
            CategoryId= 2,
            Name = "kitapurun4",
            Price = 4,
            Stock= 4,
            CreateDate= DateTime.Now,            
            });
        }
    }
}
