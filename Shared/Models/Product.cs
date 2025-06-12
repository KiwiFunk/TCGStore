namespace Shared.Models
{
    public class Product
    {
        public int Id { get; set; }                             // Unique identifier
        public string Name { get; set; } = string.Empty;        // Product name 
        public string Description { get; set; } = string.Empty; // Product description
        public decimal Price { get; set; }                      // Price in the store
        public string ImageUrl { get; set; } = string.Empty;    // URL for an image
        public string Category { get; set; } = string.Empty;    // Category (e.g., Cards, Accessories)
    }
}