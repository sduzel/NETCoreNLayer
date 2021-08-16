using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NETCoreNLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCoreNLayer.Data.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;
        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1 , Name = "Siyah Çekirdek",CategoryId = _ids[0]},
                new Product { Id = 2, Name = "Beyaz Çekirdek", CategoryId = _ids[0] });
        }
    }
}
