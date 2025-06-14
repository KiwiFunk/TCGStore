using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeaturedProductsController : ControllerBase
    {
        private static readonly List<Featured> FeaturedProducts = new()
        {
            new Featured
            {
                Id = 1,
                ProductId = 1,  // Reference to Card Sleeves
                Headline = "Protect Your Collection in Style",
                Subheadline = "These special edition zip-up trading card binders include colour matched zips and inner microfibre lining for a full on, full colour experience.",
                HeroImageUrl = "/images/featured/vault_x_binder_pk_prp.jpg",
                ButtonText = "Shop Protection",
                ButtonUrl = "/accessories/sleeves",
                SortOrder = 1,
                BackgroundColor = "bg-gradient-to-r from-purple-900 to-blue-900"
            },
            new Featured
            {
                Id = 2,
                ProductId = 2,  // Reference to Deck Box
                Headline = "Prismatic Evolutions",
                Subheadline = "Evolve your Pokémon TCG game with Stellar Tera Eevee ex, special illustration rare cards, and more.",
                HeroImageUrl = "/images/featured/prismatic_hero.webp",
                ButtonText = "Available Now",
                ButtonUrl = "/accessories/prismatic",
                SortOrder = 2,
                BackgroundColor = "bg-gradient-to-r from-gray-900 to-blue-900"
            },
            new Featured
            {
                Id = 3,
                ProductId = 3,  // Assuming a new product
                Headline = "Magic: The Gathering — FINAL FANTASY",
                Subheadline = "The beloved FINAL FANTASY RPG series' sixteen mainline games of unforgettable characters, items, and moments are now here in Magic: The Gathering!",
                HeroImageUrl = "/images/featured/mtg_ff_hero.jpg",
                ButtonText = "Pre-order Now",
                ButtonUrl = "/magic/mtg-final-fantasy",
                SortOrder = 0,  // Show first
                BackgroundColor = "bg-gradient-to-r from-stone-900 to-red-900"
            }
        };

        [HttpGet]
        public IEnumerable<Featured> Get()
        {
            return FeaturedProducts;
        }
    }
}