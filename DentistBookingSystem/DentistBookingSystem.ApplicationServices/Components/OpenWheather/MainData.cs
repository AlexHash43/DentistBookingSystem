using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.Components.OpenWheather
{
    public class MainData
    {
        [JsonProperty("temp")]
        public string Temperature { get; set; }
        [JsonProperty("humidity")]
        public string Humidity { get; set; }

        [JsonProperty("pressure")]
        public string Pressure { get; set; }
    }
}
