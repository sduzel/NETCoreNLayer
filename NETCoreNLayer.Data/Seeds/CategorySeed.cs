using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NETCoreNLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCoreNLayer.Data.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        private readonly int[] _ids;
        public CategorySeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category { Id = _ids[0], Name = "Çekirdek" },
                            new Category { Id = _ids[1], Name = "Arpa" },
                            new Category { Id = _ids[2], Name = "Buğday" });
        }
    }
}
