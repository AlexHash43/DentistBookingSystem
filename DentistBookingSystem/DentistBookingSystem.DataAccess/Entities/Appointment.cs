using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.Entities
{
    public class Appointment : EntityBase
    {
        public string Reason { get; set; }



        
        public List<User> Users { get; set; }
    }
}
