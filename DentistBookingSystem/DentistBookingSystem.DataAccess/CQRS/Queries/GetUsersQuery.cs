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
        public override Task<List<User>> Execute(AppointmentStorageContext context)
        {
            return context.Users.ToListAsync();
            
        }
    }
}
