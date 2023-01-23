using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamesRental.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public decimal PriceTotal { get; set; }
        public bool IsPaid { get; set; }
        [ForeignKey("Game")]
        public int GameId { get; set; }
        public Game Game { get; set; }

    }
}
