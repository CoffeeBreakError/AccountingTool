using System;
using System.Collections.Generic;
using System.Text;
using AccountingTool.DAL.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingTool.DAL.EF.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Season)
                .WithMany(c => c.Items)
                .HasForeignKey(c => c.SeasonId);

            builder.HasMany(c => c.Clothes)
                .WithOne(c => c.Item)
                .HasForeignKey(c => c.ItemId);

            builder.HasMany(c => c.ItemAccountings)
                .WithOne(c => c.Item)
                .HasForeignKey(c => c.ItemId);

            builder.HasMany(c => c.Wears)
                .WithOne(c => c.Item)
                .HasForeignKey(c => c.ItemId);
        }
    }
}
