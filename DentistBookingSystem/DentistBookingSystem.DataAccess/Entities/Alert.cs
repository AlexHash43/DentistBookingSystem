using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.Entities
{
    public class Alert : EntityBase
    {
        public string Info { get; set; }


        public List<EmergencyList> EmergencyLists{ get; set; }
    }
}
