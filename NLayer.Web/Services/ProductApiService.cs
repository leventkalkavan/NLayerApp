﻿using NLayer.Core.DTOs;

namespace NLayer.Web.Services
{
    public class ProductApiService
    {
        private readonly HttpClient _httpclient;
        public ProductApiService(HttpClient httpClient)
        {
            _httpclient = httpClient;
        }
        public async Task<List<ProductsWithCategoryDto>> GetProductsWithCategoryAsync()
        {
            var response = await _httpclient.GetFromJsonAsync<CustomResponseDto<List<ProductsWithCategoryDto>>>("products/GetProductsWithCategory");

            return response.Data;
        }
        public async Task<ProductDto> SaveAsync(ProductDto newProduct) 
        {
            var response = await _httpclient.PostAsJsonAsync("products", newProduct);
            if (!response.IsSuccessStatusCode) return null;                       
            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<ProductDto>>();
            return responseBody.Data;
        }
        public async Task<bool> UpdateAsync(ProductDto newProduct) 
        {
            var response = await _httpclient.PostAsJsonAsync("products", newProduct);

            return response.IsSuccessStatusCode;
        }
        public async Task<bool> RemoveAsync(int id) 
        {
            var response = await _httpclient.DeleteAsync($"products /{id}");

            return response.IsSuccessStatusCode;
        }
        public async Task<ProductDto> GetByIdAsync(int id)
        {
            var response = await _httpclient.GetFromJsonAsync<CustomResponseDto<ProductDto>>($"product/{id}");
            return response.Data;
        }
    }
}