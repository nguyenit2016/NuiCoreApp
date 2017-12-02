using NuiCoreApp.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace NuiCoreApp.Application.ViewModels
{
    public class BrandViewModel
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        public Status Status { get; set; }
    }
}