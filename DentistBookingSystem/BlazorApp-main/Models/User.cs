using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; } = "Patient";
        public string AuthData { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; } = DateTime.Today;
        public string PhoneNumber { get; set; }
        public DateTime DateRegistered { get; set; } = DateTime.Now;
        public string Password { get; set; }
        public string Gender { get; set; }

        
        
    }
}