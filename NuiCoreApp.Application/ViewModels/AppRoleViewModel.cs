using System;
using System.ComponentModel.DataAnnotations;

namespace NuiCoreApp.Application.ViewModels
{
    public class AppRoleViewModel
    {
        public Guid Id { get; set; }

        [StringLength(250)]
        public string Description { get; set; }
    }
}