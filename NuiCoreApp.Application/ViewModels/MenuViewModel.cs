using NuiCoreApp.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace NuiCoreApp.Application.ViewModels
{
    public class MenuViewModel
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [StringLength(255)]
        [Required]
        public string Url { get; set; }

        [StringLength(255)]
        public string Css { get; set; }

        public int? ParentId { get; set; }

        public Status Status { get; set; }
        public int SortOrder { get; set; }
    }
}