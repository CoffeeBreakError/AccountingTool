using System;
using System.Collections.Generic;
using System.Text;
using AccountingTool.DAL.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingTool.DAL.EF.Configurations
{
    public class ClothesTypeConfiguration : IEntityTypeConfiguration<ClothesType>
    {
        public void Configure(EntityTypeBuilder<ClothesType> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasMany(c => c.Clothes)
                .WithOne(c => c.ClothesType)
                .HasForeignKey(c => c.ClothesTypeId);
        }
    }
}
