using DentistBookingSystem.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.CQRS.Commands
{
    public class AddUsersCommand : CommandBase<User, User>
    {
        public override async Task<User> Execute(AppointmentStorageContext context)
        {
            await context.Users.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
