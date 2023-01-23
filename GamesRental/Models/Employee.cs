﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GamesRental.Models
{
    public class Employee : IdentityUser
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [RegularExpression("^[0-9]*$")]
        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }
        [RegularExpression("^[0-9]*$")]
        [Required(ErrorMessage = "Contact number is required")]
        public string ContactNumber { get; set; }
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }

    }
}
