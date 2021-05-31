using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.Entities
{
    public class Appointment : EntityBase
    {
        public DateTime DateStart { get; set; }
        public DateTime DateStop { get; set; }
        public string Reason { get; set; }
        public string Note { get; set; }




        [ForeignKey("Users")]
        public int UsersId { get; set; }
        public User Users { get; set; }
    }
}
