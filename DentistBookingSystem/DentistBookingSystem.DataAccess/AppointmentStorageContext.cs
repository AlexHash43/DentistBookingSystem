﻿using DentistBookingSystem.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess
{
    class AppointmentStorageContext : DbContext
    {
        public AppointmentStorageContext(DbContextOptions<AppointmentStorageContext> options)
        : base(options)
        {

        }

        
        public DbSet<User> Users { get; set; }
    }
}
