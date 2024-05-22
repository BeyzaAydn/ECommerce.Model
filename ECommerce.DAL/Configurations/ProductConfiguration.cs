using Bogus;
using ECommerce.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(x => x.Supplier)
                .WithMany(x => x.Products).
                HasForeignKey(x => x.SupplierId);
        }

        public List<Product> SeedSupplierData()
        {
            var fakeData = new Faker<Product>()
           .RuleFor(p => p.ProductName, f => f.Commerce.ProductName())
                .RuleFor(p => p.UnitPrice, f => f.Random.Decimal(1, 1000))
                .RuleFor(p => p.UnitsInStock, f => f.Random.Short(0, 100))
                .RuleFor(p => p.ImagePath, f => f.Image.PicsumUrl());
            List<Product> products = fakeData.Generate(10);
            return products;



        }
        
    }
}
