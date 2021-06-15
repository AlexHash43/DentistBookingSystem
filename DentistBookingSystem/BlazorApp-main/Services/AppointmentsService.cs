using BlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class AppointmentsService : IAppointmentsService
    {
        private IHttpService _httpService;
        public AppointmentsService(IHttpService httpService)
        {
            _httpService = httpService;
        }
        public Task<IEnumerable<Appointment>> GetAll()
        {
            return _httpService.Get<IEnumerable<Appointment>>("/appointment");
        }

        public async Task<int> Create(Appointment appointment)
        {
            var result = await _httpService.Post<Appointment>("/appointment", appointment);
            return result.Id;
        }

        public async Task<int> Delete(int id)
        {
            await _httpService.Delete($"/appointment/{id}");
            return id;
        }
        public async Task<int> Update(Appointment appointment)
        {
            var result = await _httpService.Put<Appointment>($"/appointment/{appointment.Id}", appointment);
            return result.Id;
        }

        public Task<Appointment> GetById(int id)
        {
            return _httpService.Get<Appointment>($"/appointment/{id}");
        }

        
    }
}
