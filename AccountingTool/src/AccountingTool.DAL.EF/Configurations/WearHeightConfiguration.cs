using AccountingTool.DAL.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingTool.DAL.EF.Configurations
{
    public class WearHeightConfiguration : IEntityTypeConfiguration<WearHeight>
    {
        public void Configure(EntityTypeBuilder<WearHeight> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasMany(c => c.WearProportions)
                .WithOne(c => c.WearHeight)
                .HasForeignKey(c => c.WearHeightId);
        }
    }
}
