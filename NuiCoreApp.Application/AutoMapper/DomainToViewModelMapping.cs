using AutoMapper;
using NuiCoreApp.Application.ViewModels;
using NuiCoreApp.Data.Entities;

namespace NuiCoreApp.Application.AutoMapper
{
    public class DomainToViewModelMapping : Profile
    {
        public DomainToViewModelMapping()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Function, FunctionViewModel>();
        }
    }
}