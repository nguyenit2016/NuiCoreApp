using NuiCoreApp.Data.Enums;
using NuiCoreApp.Data.Interfaces;
using NuiCoreApp.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NuiCoreApp.Data.Entities
{
    [Table("ProductCategories")]
    public class ProductCategory : DomainEntity<int>, IHasSeoMetaData, ISwitchable, ISortable, IDateTracking
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public int? ParentId { get; set; }
        public int? HomeOrder { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [Required]
        public bool HomeFlag { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        [Required]
        public int SortOrder { get; set; }

        public Status Status { get; set; }

        [StringLength(255)]
        public string SeoPageTitle { get; set; }

        [StringLength(255)]
        [Column(TypeName = "varchar")]
        public string SeoAlias { get; set; }

        [StringLength(255)]
        public string SeoKeyWord { get; set; }

        [StringLength(255)]
        public string SeoDescription { get; set; }
    }
}