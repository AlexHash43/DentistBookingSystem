﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.Entities
{
    public class EmergencyList : EntityBase
    {
        
        public int UserId { get; set; }
        public User User { get; set; }


        public int AlertId { get; set; }
        public Alert Alert { get; set; }

    }
}
