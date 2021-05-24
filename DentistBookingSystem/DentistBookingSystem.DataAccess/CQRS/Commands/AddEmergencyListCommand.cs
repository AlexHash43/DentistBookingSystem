using DentistBookingSystem.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.CQRS.Commands
{
    public class AddEmergencyListCommand : CommandBase<EmergencyList, EmergencyList>
    {
        public async override Task<EmergencyList> Execute(AppointmentStorageContext context)
        {
            await context.EmergencyLists.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
