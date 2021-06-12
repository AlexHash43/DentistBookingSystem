using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.DataAccess;
using DentistBookingSystem.DataAccess.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DentistBookingSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AppointmentController : ApiControllerBase
    {
        
        public AppointmentController(IMediator mediator, ILogger<AppointmentController> logger) : base(mediator)
        {
            logger.LogInformation("We are in Appointment Controller");
        }

        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAllAppointments([FromQuery] GetAppointmentRequest request)
        {
            return this.HandleRequest<GetAppointmentRequest, GetAppointmentResponse>(request);
        }
        [HttpGet]
        [Route("{apointmentId}")]
        public Task<IActionResult> GetByID([FromRoute] int apointmentId)
        {
            var request = new GetAppointmentByIdRequest()
            {
                Id = apointmentId
            };
            return this.HandleRequest<GetAppointmentByIdRequest, GetAppointmentByIdResponse>(request);
        }

        [HttpPost]
        [Route("")]
        public Task<IActionResult> AddAppointment([FromBody] AddAppointmentRequest request)
        {

            return this.HandleRequest<AddAppointmentRequest, AddAppointmentResponse>(request);
        }

        [HttpPut]
        [Route("{apointmentId}")]
        public Task<IActionResult> UpdateAppointment([FromBody] UpdateAppointmentRequest request, [FromRoute] int apointmentId)
        {
            request.Id = apointmentId;
            return this.HandleRequest<UpdateAppointmentRequest, UpdateAppointmentResponse>(request);
        }

        [HttpDelete]
        [Route("{appointmentId}")]
        public Task<IActionResult> DeleteAppointment([FromRoute] int appointmentId)
        {
            var request = new DeleteAppointmrntByIdRequest()
            {
                Id = appointmentId
            };

            return this.HandleRequest<DeleteAppointmrntByIdRequest, DeleteAppointmrntByIdResponse>(request);
        }
    }
}
