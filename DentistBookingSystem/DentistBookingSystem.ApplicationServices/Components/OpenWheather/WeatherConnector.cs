using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.Components.OpenWheather
{
    public class WeatherConnector : IWeatherConnector
    {
        private readonly RestClient restClient;
        private readonly string baseUrl = "http://api.openweathermap.org/";
        private readonly string apiKey = "7cff52d269dea08c6d064bbba5089fc7";

        public WeatherConnector()
        {
            this.restClient = new RestClient(baseUrl);
        }
        public async Task<Wheather> Fetch(string city)
        {
            var request = new RestRequest("data/2.5/weather", Method.GET);
            request.AddParameter("appid", this.apiKey);
            request.AddParameter("q", city);

            var queryResult = await restClient.ExecuteAsync(request);
            var weather = JsonConvert.DeserializeObject<Wheather>(queryResult.Content);
            return weather;


        }
    }
}
