using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace proyectoU.Utilities
{
    class Serializer
    {
        public static void save<U>(U o, string filename)
        {
            try
            {
                string json = JsonConvert.SerializeObject(o);
                using (StreamWriter fileWriter = new StreamWriter(filename))
                {
                    fileWriter.WriteLine(json);
                }
            }
            catch (FileNotFoundException ex)
            {
                throw new Exception($"Error al cargar el archivo: {ex.Message}");
            }
        }

        public static U Load<U>(string filepath)
        {
            try
            {
                using (StreamReader fileReader = new StreamReader(filepath))
                {
                    return JsonConvert.DeserializeObject<U>(fileReader.ReadToEnd());
                }
            }
            catch (FileNotFoundException ex)
            {
                throw new Exception($"Error al cargar el archivo: {ex.Message}");
            }
        }
    }
}
