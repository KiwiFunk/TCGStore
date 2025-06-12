using System.Net.Http.Json;
using Shared.Models;

namespace Client.Services
{
    public class CardService
    {
        private readonly HttpClient _httpClient;

        public CardService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // GET request to fetch the list of cards from API
        public async Task<List<Card>> GetCardsAsync()
        {
            // Use null-coalescing operator (??) to return an empty list if the response is null
            return await _httpClient.GetFromJsonAsync<List<Card>>("api/cards") ?? new List<Card>();
        }
    }
}