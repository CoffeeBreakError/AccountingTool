using System;
using System.Collections.Generic;
using System.Text;
using AccountingTool.DAL.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingTool.DAL.EF.Configurations
{
    public class WearConfiguration : IEntityTypeConfiguration<Wear>
    {
        public void Configure(EntityTypeBuilder<Wear> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.WearSize)
                .WithMany(c => c.Wears)
                .HasForeignKey(c => c.WearSizeId);

            builder.HasOne(c => c.WearType)
                .WithMany(c => c.Wears)
                .HasForeignKey(c => c.WearTypeId);

            builder.HasOne(c => c.Item)
                .WithMany(c => c.Wears)
                .HasForeignKey(c => c.ItemId);
        }
    }
}
