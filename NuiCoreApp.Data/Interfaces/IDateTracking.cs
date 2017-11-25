using System;

namespace NuiCoreApp.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}