using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; } = "Patient";
        public string AuthData { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime BirthDate { get; set; } = DateTime.Today;
        [Required]
        public string PhoneNumber { get; set; }
        public DateTime DateRegistered { get; set; } = DateTime.Now;
        [Required]
        [StringLength(26, MinimumLength = 8)]
        /*[RegularExpression(@"^(?=.*?[a-z])(?=.*?[0-9]).{6,}$", // This is a very weak password requirement to make the demo easy to review. You should enforce stronger requirements
            ErrorMessage = "Password should have •  At least one lower case letter • At least one digit • Minimum 6 in length")]
        */
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }

        
        
    }
}