using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NETCoreNLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCoreNLayer.Data.Configurations
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).UseIdentityColumn();
            builder.Property(x => x.Owner).IsRequired().HasMaxLength(50);
            builder.Property(x => x.OwnerPhone).IsRequired().HasMaxLength(20);
            builder.Property(x => x.OwnerTCKN).IsRequired().HasMaxLength(15);
            builder.Property(x => x.ColorCode).IsRequired().HasMaxLength(10);
            builder.Property(x => x.OwnerAddress).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.Price).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Amount).IsRequired().HasMaxLength(10);
            builder.ToTable("Offers");
        }
    }
}
