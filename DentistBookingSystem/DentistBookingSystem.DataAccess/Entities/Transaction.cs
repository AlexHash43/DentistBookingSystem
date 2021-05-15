using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.Entities
{
    public class Transaction : EntityBase
    {
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
