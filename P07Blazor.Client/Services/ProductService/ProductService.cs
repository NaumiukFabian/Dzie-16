using P05Sklep.Shared;
using System.Net.Http.Json;

namespace P07Blazor.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ServiceResponse<Product[]>> GetProducts()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Product[]>>("api/product");

            return result;
        }
    }
}
