using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineStore.Data.Entities;

namespace WineStore.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).IsRequired();
            builder.Property(x => x.description);
            builder.Property(x=>x.mfg).IsRequired();
            builder.Property(x=>x.current_quantity).IsRequired().HasDefaultValue(0);
            builder.Property(x=>x.brand).IsRequired();
            builder.Property(x=>x.capacity).IsRequired();
            builder.Property(x=>x.concentration).IsRequired();
            builder.Property(x=>x.original_price).IsRequired();
            builder.Property(x=>x.origin).IsRequired();

        }
    }
}
