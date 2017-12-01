using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NuiCoreApp.Data.EF.Extensions;
using NuiCoreApp.Data.Entities;

namespace NuiCoreApp.Data.EF.Configurations
{
    public class AnnouncementConfiguration : DbEntityConfiguration<Announcement>
    {
        public override void Configure(EntityTypeBuilder<Announcement> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
            // etc.
        }
    }
}
