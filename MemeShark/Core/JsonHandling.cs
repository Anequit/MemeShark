using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MemeShark.Core
{
    static public class JsonHandling
    {
        public static void Save(object jsonObject, string filePath)
        {
            var jsonToWrite = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);

            using (var writer = new StreamWriter(filePath))
            {
                writer.Write(jsonToWrite);
                writer.Close();
            }
        }

        public static object Load(string filePath)
        {
            string Serialized = "{}";

            using (var reader = new StreamReader(filePath))
            {
                Serialized = reader.ReadToEnd();
            }

            var obj = JsonConvert.DeserializeObject<object>(Serialized);
            return obj;
        }
    }
}
