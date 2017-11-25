using NuiCoreApp.Data.Enums;
using NuiCoreApp.Data.Interfaces;
using NuiCoreApp.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NuiCoreApp.Data.Entities
{
    [Table("Menus")]
    public class Menu : DomainEntity<int>, ISwitchable, ISortable
    {
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