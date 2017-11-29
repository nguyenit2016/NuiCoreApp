using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NuiCoreApp.Application.ViewModels
{
    internal class AdvertisementPositionViewModel
    {
        public string Id { get; set; }

        [StringLength(20)]
        public int PageId { get; set; }

        [StringLength(250)]
        [Required]
        public string Name { get; set; }

        public PageViewModel Page { get; set; }

        public ICollection<AdvertisetmentViewModel> Advertisetments { get; set; }
    }
}