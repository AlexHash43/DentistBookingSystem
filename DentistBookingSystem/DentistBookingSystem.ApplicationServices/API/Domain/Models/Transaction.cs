﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Domain.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Price { get; set; }

        
        public int UserId { get; set; }
        
    }
}
