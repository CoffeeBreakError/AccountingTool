using System;
using System.Collections.Generic;
using System.Text;
using AccountingTool.DAL.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingTool.DAL.EF.Configurations
{
    public class ClothesSizeConfiguration : IEntityTypeConfiguration<ClothesSize>
    {
        public void Configure(EntityTypeBuilder<ClothesSize> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasMany(c => c.Clothes)
                .WithOne(c => c.ClothesSize)
                .HasForeignKey(c => c.ClothesSizeId);
        }
    }
}
