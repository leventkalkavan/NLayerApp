﻿using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Model;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;

namespace NLayer.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IMapper mapper, IProductRepository productRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<CustomResponseDto<List<ProductsWithCategoryDto>>> GetProductsWithCategory()
        {
            var products = await _productRepository.GetProductsWithCategory();
            var productsDto = _mapper.Map<List<ProductsWithCategoryDto>>(products);

            return CustomResponseDto<List<ProductsWithCategoryDto>>.Success(200,productsDto);
        }
    }
}
