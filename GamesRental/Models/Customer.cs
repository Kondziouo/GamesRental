using System.ComponentModel.DataAnnotations;

namespace GamesRental.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }

    }
}
