using System.Collections.Generic;

namespace Shared.Models
{
    public class Featured
    {
        public int Id { get; set; }                                     // Unique identifier for the featured item
        public int ProductId { get; set; }                              // Reference to the base product
        public string Headline { get; set; } = string.Empty;            // Main headline text (e.g., "Make Your Collection More Exclusive & Premium")
        public string Subheadline { get; set; } = string.Empty;         // Secondary descriptive text
        public string HeroImageUrl { get; set; } = string.Empty;        // High-resolution hero image
        public string ButtonText { get; set; } = "Shop Now";            // Call to action text
        public string ButtonUrl { get; set; } = string.Empty;           // Button href
        public int SortOrder { get; set; } = 0;                         // Control display order in carousel
        
        // Optional: Visual customization options
        public string TextColor { get; set; } = "text-white";  // Default white text
        public string BackgroundColor { get; set; } = "bg-gray-900";  // Default dark background
    }
}