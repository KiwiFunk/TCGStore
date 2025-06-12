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
            new Product { Id = 1, Name = "Card Sleeves", Description = "Protect your cards with premium sleeves.", Price = 5.99m, ImageUrl = "/images/card-sleeves.png", Category = "Accessories" },
            new Product { Id = 2, Name = "Deck Box", Description = "Store your deck safely.", Price = 9.99m, ImageUrl = "/images/deck-box.png", Category = "Accessories" }
        };

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return Products;
        }
    }
}