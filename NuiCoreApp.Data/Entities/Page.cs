using NuiCoreApp.Data.Enums;
using NuiCoreApp.Data.Interfaces;
using NuiCoreApp.Infrastructure.SharedKernel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NuiCoreApp.Data.Entities
{
    [Table("Pages")]
    public class Page : DomainEntity<int>, ISwitchable
    {
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