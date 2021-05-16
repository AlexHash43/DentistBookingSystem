using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Domain.Models
{
    public class Alert
    {
        public string Info { get; set; }


        public List<DentistBookingSystem.DataAccess.Entities.EmergencyList> EmergencyLists { get; set; }
    }
}
