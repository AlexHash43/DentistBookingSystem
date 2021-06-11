using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.Entities
{
    
    public class Appointment : EntityBase
    {
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeStop { get; set; }
        public DateTime TimeAndDateBooked { get; set; } = DateTime.UtcNow;
        public string Reason { get; set; }
        public string Note { get; set; }
        public bool StatusBooked { get; set; }

        public List<Transaction> Transactions { get; set; }




        [ForeignKey("Users")]
        public int UsersId { get; set; }
        public User Users { get; set; }
    }
}
