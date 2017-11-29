using System.ComponentModel.DataAnnotations;

namespace NuiCoreApp.Application.ViewModels
{
    public class FooterViewModel
    {
        public string Id { get; set; }

        [Required]
        public string Content { get; set; }
    }
}