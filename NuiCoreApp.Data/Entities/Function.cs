﻿using NuiCoreApp.Data.Enums;
using NuiCoreApp.Data.Interfaces;
using NuiCoreApp.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NuiCoreApp.Data.Entities
{
    [Table("Functions")]
    public class Function : DomainEntity<string>, ISwitchable, ISortable
    {
        public Function()
        {
        }

        public Function(string name, string url, string parentId, string iconCss, int sortOrder)
        {
            this.Name = name;
            this.URL = url;
            this.ParentId = parentId;
            this.IconCss = iconCss;
            this.SortOrder = sortOrder;
            this.Status = Status.Active;
        }

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