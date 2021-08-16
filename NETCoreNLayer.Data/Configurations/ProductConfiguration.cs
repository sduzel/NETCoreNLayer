using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NETCoreNLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCoreNLayer.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).UseIdentityColumn();
            builder.Property(t => t.Name).IsRequired().HasMaxLength(200);
            builder.ToTable("Products");
        }
    }
}
