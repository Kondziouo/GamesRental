using System.ComponentModel.DataAnnotations;

namespace GamesRental.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Address email is required")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string email { get; set; }

    }
}
