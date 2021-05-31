using DentistBookingSystem.ApplicationServices.Components.OpenWheather;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentistBookingSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IWeatherConnector weatherConnector;
        public WeatherForecastController(IMediator mediator, IWeatherConnector weatherConnector)
        {
            this.mediator = mediator;
            this.weatherConnector = weatherConnector;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetWheater()
        {
            var weather = await this.weatherConnector.Fetch("Aberdeen");
            return Ok(weather);
        }
    }
}
