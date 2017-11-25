using NuiCoreApp.Data.Enums;
using NuiCoreApp.Data.Interfaces;
using NuiCoreApp.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NuiCoreApp.Data.Entities
{
    [Table("Brands")]
    public class Brand : DomainEntity<int>, ISwitchable
    {
        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        public Status Status { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}