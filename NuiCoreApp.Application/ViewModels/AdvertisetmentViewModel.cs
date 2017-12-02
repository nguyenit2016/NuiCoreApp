using NuiCoreApp.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace NuiCoreApp.Application.ViewModels
{
    public class AdvertisetmentViewModel
    {
        public int Id { get; set; }

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

        //public AdvertisementPositionViewModel AdvertisementPosition { get; set; }
    }
}