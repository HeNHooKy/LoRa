using GreenhouseMeter.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenhouseMeter
{
    public static class FileSystem
    {
        private static readonly string Saves = "saves.json";

        public static Dictionary<int, Unit> InitializePoints()
        {
            using (var reader = new StreamReader(Saves))
            {
                var data = reader.ReadToEnd();

                var units = JsonConvert.DeserializeObject<List<Unit>>(data);

                var unitsDict = units.ToDictionary(v => v.Id, v => v);

                return unitsDict;
            }
        }

        public static void SavePoints(Dictionary<int, Unit> units)
        {
            using (var writer = new StreamWriter(Saves))
            {
                var unitsList = units.Select(u => u.Value);

                var data = JsonConvert.SerializeObject(unitsList);

                writer.Write(data);
            }
        }
    }
}
