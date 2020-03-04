using System;
using System.Collections.Generic;
using System.Text;
using AccountingTool.DAL.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingTool.DAL.EF.Configurations
{
    public class ClothesConfiguration : IEntityTypeConfiguration<Clothes>
    {
        public void Configure(EntityTypeBuilder<Clothes> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.ClothesSize)
                .WithMany(c => c.Clothes)
                .HasForeignKey(c => c.ClothesSizeId);

            builder.HasOne(c => c.ClothesType)
                .WithMany(c => c.Clothes)
                .HasForeignKey(c => c.ClothesTypeId);

            builder.HasOne(c => c.Item)
                .WithMany(c => c.Clothes)
                .HasForeignKey(c => c.ItemId);
        }
    }
}
