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




        public List<Appointment> Appointments { get; set; }
        public List<EmergencyList> EmergencyLists { get; set; }
        public List<Transaction> Transactions { get; set; }


    }
}
