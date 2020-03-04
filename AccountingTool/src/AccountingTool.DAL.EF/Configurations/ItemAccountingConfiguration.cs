using System;
using System.Collections.Generic;
using System.Text;
using AccountingTool.DAL.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingTool.DAL.EF.Configurations
{
    public class ItemAccountingConfiguration : IEntityTypeConfiguration<ItemAccounting>
    {
        public void Configure(EntityTypeBuilder<ItemAccounting> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Item)
                .WithMany(c => c.ItemAccountings)
                .HasForeignKey(c => c.ItemId);

            builder.HasOne(c => c.Employee)
                .WithMany(c => c.ItemAccountings)
                .HasForeignKey(c => c.EmployeeId);
        }
    }
}
