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

        public async Task<List<Card>> GetCardsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Card>>("api/cards") ?? new List<Card>();
        }
    }
}