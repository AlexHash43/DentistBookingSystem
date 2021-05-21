using DentistBookingSystem.ApplicationServices.API.Domain;
using MediatR;
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
    public class UsersController : ControllerBase
    {
        private readonly IMediator mediator;
        public UsersController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllUsers([FromQuery]GetUserRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }


        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddUser([FromBody] AddUsersRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

    }
}
