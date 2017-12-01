using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NuiCoreApp.Data.EF.Extensions;
using NuiCoreApp.Data.Entities;

namespace NuiCoreApp.Data.EF.Configurations
{
    class SystemConfigConfiguration : DbEntityConfiguration<SystemConfig>
    {
        public override void Configure(EntityTypeBuilder<SystemConfig> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}