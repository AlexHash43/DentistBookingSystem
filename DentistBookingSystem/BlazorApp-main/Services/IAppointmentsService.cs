using BlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public interface IAppointmentsService
    {
        Task<IEnumerable<Appointment>> GetAll();
        Task<int> Create(Appointment appointment);
        Task<int> Delete(int id);
        Task<int> Update(Appointment appointment);
        Task<Appointment> GetById(int id);
    }
}
