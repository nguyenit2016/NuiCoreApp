using NuiCoreApp.Data.Enums;
using NuiCoreApp.Data.Interfaces;
using NuiCoreApp.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NuiCoreApp.Data.Entities
{
    [Table("Advertisetments")]
    public class Advertisetment : DomainEntity<int>, ISwitchable, ISortable, IDateTracking
    {
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        [StringLength(250)]
        public string Url { get; set; }

        [StringLength(20)]
        public string PositionId { get; set; }

        public Status Status { get; set; }
        public int SortOrder { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        [ForeignKey("PositionId")]
        public virtual AdvertisementPosition AdvertisementPosition { get; set; }
    }
}