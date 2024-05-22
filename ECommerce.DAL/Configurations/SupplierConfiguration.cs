using ECommerce.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.Property(x => x.Address).HasMaxLength(255);

            //HasData:veritabanında tablo oluşturulurken beraberinde varsayılan datalar ile birlikte oluşturulmasını sağlar.
            builder.HasData(SeedSupplierData());
        }

        private List<Supplier> SeedSupplierData()
        {

            List<Supplier> suppliers = new List<Supplier>();
            suppliers.Add(new Supplier { ID = 1, CompanyName = "Test Supplier 1", ContactName = "Test Supplier 1 ",Address="aa",PhoneNumber="123" });
            suppliers.Add(new Supplier { ID = 2, CompanyName = "Test Supplier 2", ContactName = "Test Supplier 2 ",Address="bb" , PhoneNumber = "123" });
            suppliers.Add(new Supplier { ID = 3, CompanyName = "Test Supplier 3", ContactName = "Test Supplier 3 ",Address="cc", PhoneNumber = "123" });

            return suppliers;
        }

    }
}
