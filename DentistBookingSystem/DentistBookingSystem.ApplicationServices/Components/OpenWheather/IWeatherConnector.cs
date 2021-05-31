using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.Components.OpenWheather
{
    public interface IWeatherConnector
    {
        Task<Wheather> Fetch(string city);

    }
}
