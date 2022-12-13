namespace NLayer.Web.Services
{
    public class ProductApiService
    {
        private readonly HttpClient _httpclient;
        public ProductApiService(HttpClient httpClient)
        {
            _httpclient = httpClient;
        }
    }
}
