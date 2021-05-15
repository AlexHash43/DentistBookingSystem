using DentistBookingSystem.DataAccess;
using DentistBookingSystem.DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentistBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IRepository<Appointment> appointmentRepository;
        public AppointmentController(IRepository<Appointment> appointmentRepository)
        {
            this.appointmentRepository = appointmentRepository;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Appointment> GetAllApointments() => this.appointmentRepository.GetAll();

        [HttpGet]
        [Route("{appointmentId}")]
        public Appointment GetAppointmentById(int appointmentId) => this.appointmentRepository.GetById(appointmentId);
    }
}
