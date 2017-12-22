using NuiCoreApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using NuiCoreApp.Application.ViewModels;
using NuiCoreApp.Data.IRepositories;
using NuiCoreApp.Infrastructure.Interfaces;
using AutoMapper;
using NuiCoreApp.Data.Entities;
using System.Linq;
using AutoMapper.QueryableExtensions;
using NuiCoreApp.Data.Enums;

namespace NuiCoreApp.Application.Implementation
{
    public class ProductCategoryService : IProductCategoryService
    {
        private IProductCategoryRepository _productCategoryRepository;
        private IUnitOfWork _unitOfWork;
        public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IUnitOfWork unitOfWork)
        {
            _productCategoryRepository = productCategoryRepository;
            _unitOfWork = unitOfWork;
        }
        public ProductCategoryViewModel Add(ProductCategoryViewModel productCategoryVm)
        {
            var productCategory = Mapper.Map<ProductCategoryViewModel, ProductCategory>(productCategoryVm);
            _productCategoryRepository.Add(productCategory);
            return productCategoryVm;
        }

        public void Delete(int id)
        {
            _productCategoryRepository.Remove(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ProductCategoryViewModel> GetAll()
        {
            return _productCategoryRepository.FindAll().OrderBy(x => x.Id)
                .ProjectTo<ProductCategoryViewModel>().ToList();
        }

        public List<ProductCategoryViewModel> GetAll(string keyword)
        {
            if(!string.IsNullOrEmpty(keyword))
                return _productCategoryRepository.FindAll(x => x.Name.Contains(keyword)
                || x.Description.Contains(keyword)).OrderBy(x => x.Id)
                .ProjectTo<ProductCategoryViewModel>().ToList();
            else
                return _productCategoryRepository.FindAll().OrderBy(x => x.Id)
                .ProjectTo<ProductCategoryViewModel>().ToList();
        }

        public List<ProductCategoryViewModel> GetAllByParentId(int parentId)
        {
            return _productCategoryRepository.FindAll(x => x.Status == Status.Active && x.ParentId == parentId)
                .OrderBy(x => x.Id).ProjectTo<ProductCategoryViewModel>().ToList();
        }

        public ProductCategoryViewModel GetById(int id)
        {
            return Mapper.Map<ProductCategory, ProductCategoryViewModel>(_productCategoryRepository.FindById(id));
        }

        public List<ProductCategoryViewModel> GetHomeCategories(int top)
        {
            var query = _productCategoryRepository.FindAll(x => x.HomeFlag == true, c => c.Products)
                .OrderBy(x => x.HomeOrder).Take(top).ProjectTo<ProductCategoryViewModel>();
            var categories = query.ToList();
            //foreach (var category in categories)
            //{
                
            //}
            return categories;
        }

        public void ReOrder(int sourceId, int targetId)
        {
            var source = _productCategoryRepository.FindById(sourceId);
            var target = _productCategoryRepository.FindById(targetId);
            int tempOrder = source.SortOrder;
            source.SortOrder = target.SortOrder;
            target.SortOrder = tempOrder;
            if (source.ParentId != null)
                source.ParentId = null;

            _productCategoryRepository.Update(source);
            _productCategoryRepository.Update(target);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductCategoryViewModel productCategoryVm)
        {
            var productCategory = Mapper.Map<ProductCategoryViewModel, ProductCategory>(productCategoryVm);
            _productCategoryRepository.Update(productCategory);
        }

        public void UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items)
        {
            var sourceCategory = _productCategoryRepository.FindById(sourceId);
            sourceCategory.ParentId = targetId;
            _productCategoryRepository.Update(sourceCategory);

            //Get all sibling
            var sibling = _productCategoryRepository.FindAll(x => items.ContainsKey(x.Id));
            foreach (var child in sibling)
            {
                child.SortOrder = items[child.Id];
                _productCategoryRepository.Update(child);
            }
        }
    }
}
