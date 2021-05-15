using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess
{
    class AppointmentStorageContextFactory : IDesignTimeDbContextFactory<AppointmentStorageContext>
    {
        public AppointmentStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppointmentStorageContext>();
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=AppointmentStorage;Integrated Security=True");

            return new AppointmentStorageContext(optionsBuilder.Options);
        }
    }
}
