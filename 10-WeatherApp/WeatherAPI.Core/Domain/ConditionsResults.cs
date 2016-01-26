using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI.Core.Domain
{
    public class ConditionsResults
    {
        public DisplayLocation Display_Location { get; set; }
        public string weather { get; set; }
        public string temperature_string { get; set; }
        public string relative_humidity { get; set; }
        public string wind_string { get; set; }
        public string visibility_mi { get; set; }
        public string UV { get; set; }
        public string feelslike_string { get; set; }
        public string precip_today_string { get; set; }
        public string observation_time { get; set; }
        public string icon_url { get; set; }
        public string icon { get; set; }
    }
}
