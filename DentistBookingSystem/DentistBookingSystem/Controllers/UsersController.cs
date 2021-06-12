using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.ApplicationServices.Components.Authorize;
using DentistBookingSystem.DataAccess.CQRS.Queries;
using DentistBookingSystem.DataAccess.Entities;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DentistBookingSystem.Controllers
{ 
    [MyAuthorize(RoleEnum = UserRoles.Administrator)]
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ApiControllerBase
    {
       
        public UsersController(IMediator mediator, ILogger<UsersController> logger) : base(mediator)
        {
            logger.LogInformation("We are in Users Controller");
        }
        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAllUsers([FromQuery]GetUserRequest request)
        {
            return this.HandleRequest<GetUserRequest, GetUserResponse>(request);
           // var response = await this.mediator.Send(request);
           // return this.Ok(response);
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

        [AllowAnonymous]
        [HttpPost]
        [Route("")]
        public Task<IActionResult> AddUser([FromBody] AddUsersRequest request)
        {
            return this.HandleRequest<AddUsersRequest, AddUsersResponse>(request);
        }

        [HttpPut]
        [Route("{userId}")]
        public Task<IActionResult> UpdateUser([FromBody]UpdateUsersRequest request, [FromRoute] int userId)
        {
            request.Id = userId;
            return this.HandleRequest<UpdateUsersRequest, UpdateUsersResponse>(request);
        }

        [HttpDelete]
        [Route("{userId}")]
        public Task<IActionResult> DeleteUserByID([FromRoute] int userId)
        {
            var request = new DeleteUserByIdRequest()
            {
                Id = userId
            };
            return this.HandleRequest<DeleteUserByIdRequest, DeleteUserByIdResponse>(request);
        }
        [Authorize]
        [HttpGet]
        [Route("me")]
        public Task<IActionResult> GetMe()
        {
            ClaimsPrincipal principal = HttpContext.User;

            var request = new GetMeRequest()
            {
                UserId = principal.FindFirst(ClaimTypes.NameIdentifier).Value
            };
            return this.HandleRequest<GetMeRequest, GetMeResponse>(request);
            
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public Task<IActionResult> Authenticate([FromBody] ValidateUserRequest request)
        {
            return this.HandleRequest<ValidateUserRequest, ValidateUserResponse>(request);
        }
    }
}
