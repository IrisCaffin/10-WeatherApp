using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using WeatherAPI.Core.Domain;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WeatherAPI.Core.Services
{
    public static class WeatherService
    {
        public static string apiKey = "aa78cf8509319d69";

        public static ConditionsResults GetWeatherFor (string zipCode)
        {
            using (WebClient wc = new WebClient())
            {
                string Json = wc.DownloadString($"http://api.wunderground.com/api/{apiKey}/conditions/q/{zipCode}.json");
                var o = JObject.Parse(Json);
                string currentlocationJson = o["current_observation"].ToString();
                var result = new ConditionsResults();
                result = JsonConvert.DeserializeObject<ConditionsResults>(currentlocationJson);
                return result;
            }
        }
    }
}
