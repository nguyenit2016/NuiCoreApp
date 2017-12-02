using NuiCoreApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NuiCoreApp.Application.ViewModels
{
    public class AnnouncementViewModel
    {
        public string Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(250)]
        public string Content { get; set; }

        [StringLength(450)]
        public string UserId { get; set; }

        public AppUserViewModel AppUser { get; set; }

        public ICollection<AnnouncementUserViewModel> AnnouncementUsers { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Status Status { get; set; }
    }
}
