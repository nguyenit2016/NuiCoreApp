using NuiCoreApp.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace NuiCoreApp.Application.ViewModels
{
    public class LanguageViewModel
    {
        public string Id { get; set; }

        [StringLength(128)]
        [Required]
        public string Name { get; set; }

        public bool Default { get; set; }
        public string Resource { get; set; }
        public Status Status { get; set; }
    }
}