using DentistBookingSystem.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.CQRS.Queries
{
    public class GetUsersQuery : QueryBase<List<User>>
    {
        public string Name { get; set; }

        public override Task<List<User>> Execute(AppointmentStorageContext context)
        {
            if (Name != null)
            {
                return context.Users.Where(x => x.Name == this.Name).ToListAsync();
            }
            return context.Users
                .Include(x => x.Appointments)
                .ToListAsync();
            
        }
    }
}
