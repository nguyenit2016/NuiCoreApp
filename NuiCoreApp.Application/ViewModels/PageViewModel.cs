using NuiCoreApp.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace NuiCoreApp.Application.ViewModels
{
    public class PageViewModel
    {
        public int Id { get; set; }

        [StringLength(256)]
        [Required]
        public string Name { get; set; }

        [StringLength(256)]
        [Required]
        public string Alias { get; set; }

        [StringLength(255)]
        public string Content { get; set; }

        public Status Status { get; set; }
    }
}