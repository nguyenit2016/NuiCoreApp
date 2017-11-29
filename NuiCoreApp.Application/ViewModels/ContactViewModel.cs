using NuiCoreApp.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace NuiCoreApp.Application.ViewModels
{
    public class ContactViewModel
    {
        public string Id { get; set; }

        [StringLength(256)]
        [Required]
        public string Name { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string Website { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public string Other { set; get; }

        [StringLength(255)]
        public string Longtitude { get; set; }

        [StringLength(255)]
        public string Latitude { get; set; }

        public Status Status { set; get; }
    }
}