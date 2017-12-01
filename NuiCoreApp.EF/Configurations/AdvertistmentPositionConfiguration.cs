using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NuiCoreApp.Data.EF.Extensions;
using NuiCoreApp.Data.Entities;

namespace NuiCoreApp.Data.EF.Configurations
{
    public class AdvertistmentPositionConfiguration : DbEntityConfiguration<AdvertistmentPosition>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPosition> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
            // etc.
        }
    }
}