using NuiCoreApp.Data.Enums;
using NuiCoreApp.Data.Interfaces;
using NuiCoreApp.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NuiCoreApp.Data.Entities
{
    [Table("Bills")]
    public class Bill : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Bill()
        {
        }

        public Bill(string customerName, string customerAddress, string customerMobile, string customerMessage,
             BillStatus billStatus, PaymentMethod paymentMethod, Status status, string customerId)
        {
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            CustomerMobile = customerMobile;
            CustomerMessage = customerMessage;
            BillStatus = billStatus;
            PaymentMethod = paymentMethod;
            Status = status;
            CustomerId = customerId;
        }

        public Bill(int id, string customerName, string customerAddress, string customerMobile, string customerMessage,
            BillStatus billStatus, PaymentMethod paymentMethod, Status status, string customerId)
        {
            Id = id;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            CustomerMobile = customerMobile;
            CustomerMessage = customerMessage;
            BillStatus = billStatus;
            PaymentMethod = paymentMethod;
            Status = status;
            CustomerId = customerId;
        }

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
        [Column(TypeName = "varchar")]
        public string CustomerEmail { get; set; }

        public DateTime BillDate { get; set; }

        [StringLength(450)]
        public string CustomerId { set; get; }

        [ForeignKey("CustomerId")]
        public virtual AppUser User { set; get; }

        [DefaultValue(Status.Active)]
        public Status Status { get; set; } = Status.Active;

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}