

using DentistBookingSystem.ApplicationServices.API.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DentistBookingSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AlertController : ApiControllerBase
    {
        
        
        public AlertController(IMediator mediator, ILogger<AlertController> logger) : base(mediator)
        {
            logger.LogInformation("We are in Alert Controller");
        }

        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAllAlerts([FromQuery] GetAlertRequest request)
        {
            return this.HandleRequest<GetAlertRequest, GetAlertResponse>(request);
        }
    }
}
