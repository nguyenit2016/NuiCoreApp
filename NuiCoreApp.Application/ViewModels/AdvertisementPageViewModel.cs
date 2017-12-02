using System.Collections.Generic;

namespace NuiCoreApp.Application.ViewModels
{
    internal class AdvertisementPageViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<AdvertisementPositionViewModel> AdvertisementPositions { get; set; }
    }
}