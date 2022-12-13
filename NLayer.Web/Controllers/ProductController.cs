using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Repositories;
using NLayer.Core.Services;

namespace NLayer.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var CustomResponse = await _productService.GetProductsWithCategory();
            return View(CustomResponse.Data);
        }
    }
}