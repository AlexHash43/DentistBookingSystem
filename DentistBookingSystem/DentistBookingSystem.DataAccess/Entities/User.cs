using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentistBookingSystem.DataAccess.Entities
{
    public class User : EntityBase
    {
       
        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string Name { get; set; }


        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [MaxLength(25)]
        public string PhoneNumber { get; set; }

        [Required]
        public string Gender { get; set; }
        public DateTime DateRegistered { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        public string Salt { get; set; }








        public List<Appointment> Appointments { get; set; }
        public List<EmergencyList> EmergencyLists { get; set; }
        public List<Transaction> Transactions { get; set; }


    }
}
