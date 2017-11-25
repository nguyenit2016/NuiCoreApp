using NuiCoreApp.Data.Enums;
using NuiCoreApp.Data.Interfaces;
using NuiCoreApp.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NuiCoreApp.Data.Entities
{
    [Table("Blogs")]
    public class Blog : DomainEntity<int>, ISwitchable, IHasSeoMetaData, IDateTracking
    {
        public Blog()
        {
        }

        public Blog(string name, string thumbnailImage,
           string description, string content, bool? homeFlag, bool? hotFlag,
           string tags, Status status, string seoPageTitle,
           string seoAlias, string seoMetaKeyword,
           string seoMetaDescription)
        {
            Name = name;
            Image = thumbnailImage;
            Description = description;
            Content = content;
            HomeFlag = homeFlag;
            HotFlag = hotFlag;
            Tags = tags;
            Status = status;
            SeoPageTitle = seoPageTitle;
            SeoAlias = seoAlias;
            SeoKeyWord = seoMetaKeyword;
            SeoDescription = seoMetaDescription;
        }

        public Blog(int id, string name, string thumbnailImage,
             string description, string content, bool? homeFlag, bool? hotFlag,
             string tags, Status status, string seoPageTitle,
             string seoAlias, string seoMetaKeyword,
             string seoMetaDescription)
        {
            Id = id;
            Name = name;
            Image = thumbnailImage;
            Description = description;
            Content = content;
            HomeFlag = homeFlag;
            HotFlag = hotFlag;
            Tags = tags;
            Status = status;
            SeoPageTitle = seoPageTitle;
            SeoAlias = seoAlias;
            SeoKeyWord = seoMetaKeyword;
            SeoDescription = seoMetaDescription;
        }

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
        public virtual ICollection<BlogTag> BlogTags { set; get; }

        public Status Status { get; set; }

        [MaxLength(256)]
        public string SeoPageTitle { get; set; }

        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string SeoAlias { get; set; }

        [MaxLength(256)]
        public string SeoKeyWord { get; set; }

        [MaxLength(256)]
        public string SeoDescription { get; set; }

        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}