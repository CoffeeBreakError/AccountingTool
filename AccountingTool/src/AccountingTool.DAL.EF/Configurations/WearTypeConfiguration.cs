using System;
using System.Collections.Generic;
using System.Text;
using AccountingTool.DAL.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingTool.DAL.EF.Configurations
{
    public class WearTypeConfiguration : IEntityTypeConfiguration<WearType>
    {
        public void Configure(EntityTypeBuilder<WearType> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasMany(c => c.Wears)
                .WithOne(c => c.WearType)
                .HasForeignKey(c => c.WearTypeId);
        }
    }
}
