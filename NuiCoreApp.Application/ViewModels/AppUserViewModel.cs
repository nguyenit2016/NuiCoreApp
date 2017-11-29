using NuiCoreApp.Data.Enums;
using System;

namespace NuiCoreApp.Application.ViewModels
{
    public class AppUserViewModel
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTime? BirthDay { set; get; }
        public decimal Balance { get; set; }
        public string Avatar { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}