using System.ComponentModel.DataAnnotations;

namespace NuiCoreApp.Application.ViewModels
{
    public class TagViewModel
    {
        public string Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string Type { get; set; }
    }
}