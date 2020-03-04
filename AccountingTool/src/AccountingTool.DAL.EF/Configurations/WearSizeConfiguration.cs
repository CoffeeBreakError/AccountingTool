using System;
using System.Collections.Generic;
using System.Text;
using AccountingTool.DAL.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingTool.DAL.EF.Configurations
{
    public class WearSizeConfiguration : IEntityTypeConfiguration<WearSize>
    {
        public void Configure(EntityTypeBuilder<WearSize> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasMany(c => c.WearProportions)
                .WithOne(c => c.WearSize)
                .HasForeignKey(c => c.WearSizeId);
        }
    }
}
