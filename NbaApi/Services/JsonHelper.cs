using NbaApi.ApiEntities.Teams;
using NbaApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaApi.Services
{
    public class JsonHelper<T> where T : class
    {
        public static void Serialize(List<T> values, string filename)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter(filename))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, values);
                }
            }
        }

        public static List<T> Deserialize(string filename)
        {
            List<T> values = new List<T>();
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader(filename))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    values = serializer.Deserialize<List<T>>(jr);
                }
            }
            return values;
        }

    }
}
