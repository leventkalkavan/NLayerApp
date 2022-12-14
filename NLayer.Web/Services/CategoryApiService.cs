using NLayer.Core.DTOs;

namespace NLayer.Web.Services
{
    public class CategoryApiService
    {
        private readonly HttpClient _httpclient;
        public CategoryApiService(HttpClient httpClient)
        {
            _httpclient = httpClient;
        }
        public async Task<List<CategoryDto>> GetAllAsync()
        {
            var response = await _httpclient.GetFromJsonAsync<CustomResponseDto<List<CategoryDto>>>
                ("categories");
            return response.Data;
        }
    }
}
