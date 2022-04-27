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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).UseIdentityColumn();
            builder.Property(x=>x.order_date).IsRequired();
            builder.Property(x=>x.total_price).IsRequired();
            builder.Property(x=>x.ship_name).IsRequired();
            builder.Property(x=>x.ship_email).IsUnicode(false).HasMaxLength(50);
            builder.Property(x=>x.ship_address).IsRequired();
            builder.Property(x=>x.ship_phone).IsRequired();
            builder.Property(x=>x.status).IsRequired();

        }
    }
}
