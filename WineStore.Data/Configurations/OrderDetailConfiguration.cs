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
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("Order Detail");
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).UseIdentityColumn();
            builder.Property(x => x.quantity).IsRequired();
            builder.Property(x => x.unit_price).IsRequired();

            builder.HasOne(x => x.Order)
                .WithMany(y => y.orderDetails)
                .HasForeignKey(y => y.order_id);

            builder.HasOne(x => x.Product)
                .WithMany(y => y.orderDetails)
                .HasForeignKey(y => y.product_id);
        } 
    }
}
