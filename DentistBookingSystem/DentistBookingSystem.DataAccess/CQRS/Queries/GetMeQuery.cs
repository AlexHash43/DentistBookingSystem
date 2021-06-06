using DentistBookingSystem.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.CQRS.Queries
{
    public class GetMeQuery : QueryBase<User>
    {
        public int Id { get; set; }
        public override async Task<User> Execute(AppointmentStorageContext context)
        {
            var user = await context.Users.FirstOrDefaultAsync(x =>x.Id == this.Id);
            return user;
        }
    }
}
