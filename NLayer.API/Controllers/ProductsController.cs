using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Model;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    public class ProductsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService <Product> _service;
        private readonly IProductService productService;

        public ProductsController(IService<Product> service, IMapper mapper, IProductService productService)
        {
            _service = service;
            _mapper = mapper;
            this.productService = productService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductsWithCategory()
        {
            return CreateActionResult(await productService.GetProductsWithCategory());
        }

        [HttpGet]
        public async Task<IActionResult>All() 
        {
            var products = await _service.GetAllAsync();
            var productsDtos = _mapper.Map<List<ProductDto>>(products.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200,productsDtos));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult>GetById(int id) 
        {
            var products = await _service.GetByIdAsync(id);
            var productsDtos = _mapper.Map<ProductDto>(products);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200,productsDtos));
        }
        [HttpPost]
        public async Task<IActionResult>Save(ProductDto productDto) 
        {
            var product = await _service.AddAsync(_mapper.Map<Product>(productDto));
            var productsDtos = _mapper.Map<ProductDto>(product);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200,productsDtos));
        }
        [HttpPut]
        public async Task<IActionResult>Update(ProductDto productDto) 
        {
            await _service.UpdateAsync(_mapper.Map<Product>(productDto));
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(204));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var product = await _service.GetByIdAsync(id);

            await _service.RemoveAsync(product);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
