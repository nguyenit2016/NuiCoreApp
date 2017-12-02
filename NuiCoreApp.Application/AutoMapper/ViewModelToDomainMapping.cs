using AutoMapper;
using NuiCoreApp.Application.ViewModels;
using NuiCoreApp.Data.Entities;

namespace NuiCoreApp.Application.AutoMapper
{
    public class ViewModelToDomainMapping : Profile
    {
        public ViewModelToDomainMapping()
        {
            CreateMap<ProductCategoryViewModel, ProductCategory>()
                .ConstructUsing(c => new ProductCategory(
                    c.Name, c.Description, c.ParentId, c.HomeOrder, c.Image, c.HomeFlag, c.SortOrder, c.Status
                        , c.SeoPageTitle, c.SeoAlias, c.SeoKeyWord, c.SeoDescription
                    ));
        }
    }
}