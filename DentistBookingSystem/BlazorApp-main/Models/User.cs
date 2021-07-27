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
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "The Password you entered did not match.")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Gender { get; set; }



    }
}