using System.ComponentModel.DataAnnotations;

namespace GamesRental.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal PricePerMonth { get; set; }
        public decimal Price { get; set; }

    }
}
