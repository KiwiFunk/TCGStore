using System.Net.Http.Json;
using Shared.Models;

namespace Client.Services
{
    public class FeaturedProductService
    {
        private readonly HttpClient _httpClient;

        public FeaturedProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // GET request to fetch featured products from API
        public async Task<List<Featured>> GetFeaturedProductsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Featured>>("api/featuredproducts") ?? new List<Featured>();
        }
    }
}