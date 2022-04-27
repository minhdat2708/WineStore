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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(x => x.id);
            builder.Property(x => x.name).IsRequired();

            builder.HasMany<Product>(p => p.Products)
                .WithOne(c => c.Category)
                .HasForeignKey(c => c.category_id);
        }
    }
}
