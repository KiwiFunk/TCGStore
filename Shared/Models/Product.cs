namespace Shared.Models
{
    public class Product
    {
        public int Id { get; set; }                             // Unique identifier
        public string Name { get; set; } = string.Empty;        // Product name 
        public string Description { get; set; } = string.Empty; // Product description
        public decimal Price { get; set; }                      // Price in the store
        public string ImageUrl { get; set; } = string.Empty;    // URL for an image

        // Product Categories and sorting
        public string Category { get; set; } = string.Empty;    // Category (e.g., Pokemon, MTG, Yu-Gi-Oh!, Accessories)
        public string SubCategory { get; set; } = string.Empty; // Subcategory (e.g., Boosters, Decks, Japanese Cards)
        public Dictionary<string, string> Attributes { get; set; } = new Dictionary<string, string>();  // Additional attributes (e.g., set, blister, ETB, etc.)

        // Stock and availability
        public int StockQuantity { get; set; }                  // Number of items in stock
        public bool IsInStock => StockQuantity > 0;             // Is the product in stock?

    }
}