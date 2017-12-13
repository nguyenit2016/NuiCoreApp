using Microsoft.AspNetCore.Mvc;
using NuiCoreApp.Application.Interfaces;

namespace NuiCoreApp.Areas.Admin.Controllers
{
    public class ProductController : AdminBaseController
    {
        private IProductService _productService;
        private IProductCategoryService _productCategoryService;

        public ProductController(IProductService productService, IProductCategoryService productCategoryService)
        {
            _productService = productService;
            _productCategoryService = productCategoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Ajax API

        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _productService.GetAll();
            return new ObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetAllPaging(int? categoryId, string keyWord, int page, int pageSize)
        {
            var model = _productService.GetAllPaging(categoryId, keyWord, page, pageSize);
            return new ObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var model = _productCategoryService.GetAll();
            return new ObjectResult(model);
        }
        #endregion Ajax API
    }
}