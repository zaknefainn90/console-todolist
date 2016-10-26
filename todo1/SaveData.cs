using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using Newtonsoft.Json;


namespace todo1
{
    class SaveData
    {
        private static string mainPath = AppDomain.CurrentDomain.BaseDirectory + @"\dane.json";

        public static void saveToRootFile()
        {
            string json = JsonConvert.SerializeObject(Service.tasks);
            File.WriteAllText(mainPath, json);
        }
    }
}
