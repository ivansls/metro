﻿using Newtonsoft.Json;
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
        public static string desktop = Environment.GetFolderPath((Environment.SpecialFolder.Desktop));
        public static void MySerialeze<T>(T pers)
        {

            string json = JsonConvert.SerializeObject(pers);
            File.WriteAllText(desktop + "\\manager.json", json);
        }

        public static T MyDesirialize<T>()
        {


            string json = File.ReadAllText(desktop + "\\manager.json");
            T type = JsonConvert.DeserializeObject<T>(json);
            return type;
        }
    }
}
