using System;
using System.Collections.Generic;
using System.Text;
using AccountingTool.DAL.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingTool.DAL.EF.Configurations
{
    public class WearProportionConfiguration : IEntityTypeConfiguration<WearProportion>
    {
        public void Configure(EntityTypeBuilder<WearProportion> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasMany(c => c.Wears)
                .WithOne(c => c.WearSize)
                .HasForeignKey(c => c.WearSizeId);

            builder.HasOne(c => c.WearSize)
                .WithMany(c => c.WearProportions)
                .HasForeignKey(c => c.WearSizeId);

            builder.HasOne(c => c.WearHeight)
                .WithMany(c => c.WearProportions)
                .HasForeignKey(c => c.WearHeightId);
        }
    }
}
