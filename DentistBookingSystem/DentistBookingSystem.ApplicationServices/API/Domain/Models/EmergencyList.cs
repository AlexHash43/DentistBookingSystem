using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentistBookingSystem.DataAccess.Entities;

namespace DentistBookingSystem.ApplicationServices.API.Domain.Models
{
    public class EmergencyList
    {
        public int UserId { get; set; }
        public DentistBookingSystem.DataAccess.Entities.User User { get; set; }


        public int AlertId { get; set; }
        

    }
}
