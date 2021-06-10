using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.Entities
{
    public class Transaction : EntityBase
    {
        public decimal Price { get; set; }

        [ForeignKey("Users")]
        public int UsersId { get; set; }
        public User Users { get; set; }


        


    }
}
