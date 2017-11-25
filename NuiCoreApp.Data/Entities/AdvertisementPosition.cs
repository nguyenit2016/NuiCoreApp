using NuiCoreApp.Infrastructure.SharedKernel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NuiCoreApp.Data.Entities
{
    [Table("AdvertisementPositions")]
    public class AdvertisementPosition : DomainEntity<string>
    {
        [StringLength(20)]
        public int PageId { get; set; }

        [StringLength(250)]
        [Required]
        public string Name { get; set; }

        [ForeignKey("PageId")]
        public virtual Page Page { get; set; }

        public virtual ICollection<Advertisetment> Advertisetments { get; set; }
    }
}