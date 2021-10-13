using GreenhouseMeter.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace GreenhouseMeter
{
    public static class LoRaController
    {
        public static IEnumerable<Unit> GetActual()
        {
            var response = MakeRequest();

            var units = JsonConvert.DeserializeObject<List<Unit>>(response);

            return units;
        }

        private static string MakeRequest()
        {
            //TODO: make request to base by LoRa
            return null;
        }
    }
}
