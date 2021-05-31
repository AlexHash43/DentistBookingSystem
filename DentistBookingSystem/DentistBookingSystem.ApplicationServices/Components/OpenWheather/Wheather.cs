using Newtonsoft.Json;

namespace DentistBookingSystem.ApplicationServices.Components.OpenWheather
{
    public class Wheather
    {
        public string Name { get; set; }

        [JsonProperty("main")]
        public MainData Main { get; set; }
    }
}