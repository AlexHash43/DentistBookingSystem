using System;
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

    }
}
