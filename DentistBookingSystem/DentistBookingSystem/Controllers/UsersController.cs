using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.DataAccess.CQRS.Queries;
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
    public class UsersController : ApiControllerBase
    {
       
        public UsersController(IMediator mediator) : base(mediator)
        { 
        }
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllUsers([FromQuery]GetUserRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpGet]
        [Route("{userId}")]
        public Task<IActionResult> GetByID([FromRoute] int userId)
        {
            var request = new GetUserByIdRequest()
            {
                UserId = userId
            };
            return this.HandleRequest<GetUserByIdRequest, GetUserByIdResponse>(request);
        }


        [HttpPost]
        [Route("")]
        public Task<IActionResult> AddUser([FromBody] AddUsersRequest request)
        {
            return this.HandleRequest<AddUsersRequest, AddUsersResponse>(request);
        }

        [HttpPut]
        [Route("{userId}")]
        public async Task<IActionResult> UpdateUser([FromBody]UpdateUsersRequest request, [FromRoute] int userId)
        {
            request.Id = userId;
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpDelete]
        [Route("{userId}")]
        public async Task<IActionResult> DeleteUserByID([FromRoute] int userId)
        {
            var request = new DeleteUserByIdRequest()
            {
                Id = userId
            };
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }
}
