using System.Net.Http.Json;
using Shared.Models;

namespace Client.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // GET request to fetch the list of products from API
        public async Task<List<Product>> GetProductsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>("api/products") ?? new List<Product>();
        }
    }
}