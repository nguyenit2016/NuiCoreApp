using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NuiCoreApp.Application.ViewModels
{
    public class AnnouncementUserViewModel
    {
        public int Id { get; set; }
        [StringLength(128)]
        [Required]
        public string AnnouncementId { get; set; }

        [StringLength(450)]
        [Required]
        public string UserId { get; set; }

        public bool HasRead { get; set; }

        public AppUserViewModel AppUser { get; set; }

        public AnnouncementViewModel Announcement { get; set; }
    }
}
