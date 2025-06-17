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

        // GET request to fetch the list of ALL products from API
        public async Task<List<Product>> GetProductsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>("api/products") ?? new List<Product>();
        }

        // Get products by category. E.g "Pokemon"
        public async Task<List<Product>> GetProductsByCategoryAsync(string category)
        {
            var allProducts = await GetProductsAsync();
            return allProducts.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // Get products by subcategory within a category. E.g "Pokemon" -> "Singles"
        public async Task<List<Product>> GetProductsBySubcategoryAsync(string category, string subcategory)
        {
            var allProducts = await GetProductsAsync();
            return allProducts.Where(p => 
                p.Category.Equals(category, StringComparison.OrdinalIgnoreCase) && 
                p.SubCategory.Equals(subcategory, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
        
        // Get a single product by ID
        public async Task<Product?> GetProductByIdAsync(int id)
        {
            var allProducts = await GetProductsAsync();
            return allProducts.FirstOrDefault(p => p.Id == id);
        }

        // Get a single product by slug
        public async Task<Product?> GetProductBySlugAsync(string slug)
        {
            var allProducts = await GetProductsAsync();
            return allProducts.FirstOrDefault(p => p.UrlSlug.Equals(slug, StringComparison.OrdinalIgnoreCase));
        }
    }
}

