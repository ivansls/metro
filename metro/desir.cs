using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metro
{
    internal class desir
    {
        public static void MySerialeze<T>(T pers)
        {
            string desktop = Environment.GetFolderPath((Environment.SpecialFolder.Desktop));

            string json = JsonConvert.SerializeObject(pers);
            File.WriteAllText("\\\\Mac\\Home\\Desktop\\manager.json", json);
        }

        public static T MyDesirialize<T>()
        {
            string desktop = Environment.GetFolderPath((Environment.SpecialFolder.Desktop));

            string json = File.ReadAllText("\\\\Mac\\Home\\Desktop\\manager.json");
            T type = JsonConvert.DeserializeObject<T>(json);
            return type;
        }
    }
}
