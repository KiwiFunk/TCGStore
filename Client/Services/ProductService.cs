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

        // Fetch all products from the API
        public async Task<List<Product>> GetProductsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>("api/products") ?? new List<Product>();
        }

        // Fetch products by category directly from the server
        public async Task<List<Product>> GetProductsByCategoryAsync(string category)
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>($"api/products/{category}") ?? new List<Product>();
        }

        // Fetch products by subcategory within a category directly from the server
        public async Task<List<Product>> GetProductsBySubcategoryAsync(string category, string subcategory)
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>($"api/products/{category}/{subcategory}") ?? new List<Product>();
        }

        // Fetch a single product by ID directly from the server
        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Product?>($"api/products/{id}");
        }

        // Fetch a single product by slug (if applicable in API structure)
        public async Task<Product?> GetProductBySlugAsync(string slug)
        {
            return await _httpClient.GetFromJsonAsync<Product?>($"api/products/slug/{slug}");
        }
    }
}