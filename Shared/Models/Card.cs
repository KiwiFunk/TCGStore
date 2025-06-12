namespace Shared.Models
{
    public class Card
    {
        public int Id { get; set; }                             // Unique identifier
        public string Name { get; set; } = string.Empty;        // Card name
        public string Type { get; set; } = string.Empty;        // Pokemon, MTG, Yu-Gi-Oh
        public string Rarity { get; set; } = string.Empty;      // Common, Rare, Ultra
        public decimal Price { get; set; }                      // Cost in the store
        public string ImageUrl { get; set; } = string.Empty;    // URL for an image
    }
}