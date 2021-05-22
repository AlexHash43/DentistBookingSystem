using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.DataAccess;
using DentistBookingSystem.DataAccess.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DentistBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IMediator mediator;
        public AppointmentController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllAppointments([FromQuery] GetAppointmentRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
        [HttpGet]
        [Route("{apointmentId}")]
        public async Task<IActionResult> GetByID([FromRoute] int apointmentId)
        {
            var request = new GetAppointmentByIdRequest()
            {
                Id = apointmentId
            };
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddAppointment([FromBody] AddAppointmentRequest request)
        {

            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPut]
        [Route("{apointmentId}")]
        public async Task<IActionResult> UpdateAppointment([FromBody]UpdateAppointmentRequest request, [FromRoute] int apointmentId)
        {
            request.Id = apointmentId;
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }
}
