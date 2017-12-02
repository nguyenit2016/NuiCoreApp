using NuiCoreApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NuiCoreApp.Application.ViewModels
{
    public class BlogViewModel
    {
        public int Id { get; set; }

        [StringLength(256)]
        [Required]
        public string Name { get; set; }

        [StringLength(256)]
        public string Image { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public string Content { get; set; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        public string Tags { get; set; }
        public ICollection<BlogTagViewModel> BlogTags { set; get; }

        public Status Status { get; set; }

        [MaxLength(256)]
        public string SeoPageTitle { get; set; }

        [MaxLength(256)]
        public string SeoAlias { get; set; }

        [MaxLength(256)]
        public string SeoKeyWord { get; set; }

        [MaxLength(256)]
        public string SeoDescription { get; set; }

        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}