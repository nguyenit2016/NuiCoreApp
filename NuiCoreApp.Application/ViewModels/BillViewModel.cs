using NuiCoreApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NuiCoreApp.Application.ViewModels
{
    public class BillViewModel
    {
        public int Id { get; set; }

        [StringLength(256)]
        [Required]
        public string CustomerName { get; set; }

        [StringLength(500)]
        [Required]
        public string CustomerAddress { get; set; }

        [StringLength(50)]
        [Required]
        public string CustomerMobile { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerMessage { set; get; }

        public PaymentMethod PaymentMethod { set; get; }
        public BillStatus BillStatus { set; get; }

        [StringLength(255)]
        public string CustomerEmail { get; set; }

        public DateTime BillDate { get; set; }

        [StringLength(450)]
        public string CustomerId { set; get; }

        public AppUserViewModel User { set; get; }

        [DefaultValue(Status.Active)]
        public Status Status { get; set; } = Status.Active;

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<BillDetailViewModel> BillDetails { get; set; }
    }
}