using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : ControllerBase
    {
        private static readonly List<Card> Cards = new()
        {
            new Card { Id = 1, Name = "Blue-Eyes White Dragon", Type = "Monster", Rarity = "Ultra Rare", Price = 15.99m, ImageUrl = "/images/blue-eyes.png" },
            new Card { Id = 2, Name = "Dark Magician", Type = "Monster", Rarity = "Super Rare", Price = 12.50m, ImageUrl = "/images/dark-magician.png" },
            new Card { Id = 3, Name = "Pot of Greed", Type = "Spell", Rarity = "Rare", Price = 5.00m, ImageUrl = "/images/pot-of-greed.png" }
        };

        [HttpGet]
        public IEnumerable<Card> Get()
        {
            return Cards;
        }
    }
}