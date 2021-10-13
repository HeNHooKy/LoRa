using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenhouseMeter.Model
{
    public class Unit
    {
        [JsonProperty("temp")]
        public double Temp { get; set; }
        [JsonProperty("humidity")]
        public double Humidity { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        public double Xpos { get; set; }
        public double Ypos { get; set; }

        public override string ToString()
        {
            return $"Unit number #{Id}";
        }
    }
}
