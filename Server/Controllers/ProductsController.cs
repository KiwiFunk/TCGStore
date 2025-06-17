using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> Products = new()
        {
            // Magic: The Gathering products
            new Product {
                Id = 1,
                Name = "Teferi, Time Raveler",
                Description = "Powerful planeswalker card from War of the Spark",
                Price = 24.99m,
                ImageUrl = "/images/products/teferi-time-raveler.png",
                Category = "Magic",
                SubCategory = "Singles",
                StockQuantity = 15,
                UrlSlug = "teferi-time-raveler"
            },
            new Product {
                Id = 2,
                Name = "War of the Spark Booster Box",
                Description = "36 booster packs of War of the Spark",
                Price = 119.99m,
                ImageUrl = "/images/products/war-spark-booster.png",
                Category = "Magic",
                SubCategory = "Booster Packs",
                StockQuantity = 8,
                UrlSlug = "war-of-the-spark-booster-box"
            },
            new Product {
                Id = 3,
                Name = "Eldrazi Commander Deck",
                Description = "Pre-built Commander deck featuring colorless Eldrazi",
                Price = 49.99m,
                ImageUrl = "/images/products/eldrazi-commander.png",
                Category = "Magic",
                SubCategory = "Commander Decks",
                StockQuantity = 5,
                UrlSlug = "eldrazi-commander-deck"
            },
            
            // Pokémon products
            new Product {
                Id = 4,
                Name = "Charizard VMAX",
                Description = "Rare Charizard VMAX card",
                Price = 89.99m,
                ImageUrl = "/images/products/charizard-vmax.png",
                Category = "Pokemon",
                SubCategory = "Singles",
                StockQuantity = 3,
                UrlSlug = "charizard-vmax"
            },
            new Product {
                Id = 5,
                Name = "Scarlet & Violet Booster Box",
                Description = "36 booster packs from the Scarlet & Violet set",
                Price = 129.99m,
                ImageUrl = "/images/products/scarlet-violet-booster.png",
                Category = "Pokemon",
                SubCategory = "Booster Packs",
                StockQuantity = 10,
                UrlSlug = "scarlet-violet-booster-box"
            },
            
            // Yu-Gi-Oh products
            new Product {
                Id = 6,
                Name = "Blue-Eyes White Dragon",
                Description = "Classic Blue-Eyes White Dragon card",
                Price = 19.99m,
                ImageUrl = "/images/products/blue-eyes.png",
                Category = "YuGiOh",
                SubCategory = "Singles",
                StockQuantity = 7,
                UrlSlug = "blue-eyes-white-dragon"
            },

            // Accessories
            new Product {
                Id = 7,
                Name = "Card Sleeves",
                Description = "Protect your cards with premium sleeves.",
                Price = 5.99m,
                ImageUrl = "/images/card-sleeves.png",
                Category = "Accessories",
                SubCategory = "Sleeves",
                StockQuantity = 50,
                UrlSlug = "card-sleeves"
            },
            new Product {
                Id = 8,
                Name = "Deck Box",
                Description = "Store your deck safely.",
                Price = 9.99m,
                ImageUrl = "/images/deck-box.png",
                Category = "Accessories",
                SubCategory = "Decks",
                StockQuantity = 30,
                UrlSlug = "deck-box"
            }
        };
        // GET all products
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return Products;
        }
        // GET product by ID
        [HttpGet("{id:int}")]
        public ActionResult<Product> Get(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }
        // GET products by Category
        [HttpGet("{category}")]
        public ActionResult<IEnumerable<Product>> GetByCategory(string category)
        {
            var products = Products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
            return Ok(products);
        }
        // GET products by Subcategory
        [HttpGet("{category}/{subcategory}")]
        public ActionResult<IEnumerable<Product>> GetBySubcategory(string category, string subcategory)
        {
            var products = Products.Where(p => 
                p.Category.Equals(category, StringComparison.OrdinalIgnoreCase) && 
                p.SubCategory.Equals(subcategory, StringComparison.OrdinalIgnoreCase));
                
            return Ok(products);
        }
    }
}
