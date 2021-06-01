using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentistBookingSystem.DataAccess.Entities
{
    public class User : EntityBase
    {
       
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }


        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Required]
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
        public string UserName { get; set; }
        public string Password { get; set; }







        public List<Appointment> Appointments { get; set; }
        public List<EmergencyList> EmergencyLists { get; set; }
        public List<Transaction> Transactions { get; set; }


    }
}
