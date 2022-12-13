namespace NLayer.Web.Services
{
    public class CategoryApiService
    {
        private readonly HttpClient _httpclient;
        public CategoryApiService(HttpClient httpClient)
        {
            _httpclient = httpClient;
        }
    }
}
