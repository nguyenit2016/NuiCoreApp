using NuiCoreApp.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace NuiCoreApp.Application.ViewModels
{
    public class FunctionViewModel
    {
        public string Id { get; set; }

        [StringLength(128)]
        [Required]
        public string Name { get; set; }

        [StringLength(256)]
        [Required]
        public string URL { get; set; }

        [StringLength(128)]
        public string ParentId { set; get; }

        public string IconCss { get; set; }

        public int SortOrder { get; set; }
        public Status Status { get; set; }
    }
}