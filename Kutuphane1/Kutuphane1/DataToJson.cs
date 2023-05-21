using System;
using System.Collections.Generic;
using System.IO;
using System.Text;  
using Newtonsoft.Json;

namespace Kutuphane1
{
    class DataToJson
    {
        public static void ToJson(List<Book> obj)
        {
            string json = "[\n";
            int counter = 0;
                                                               
            foreach (var item in obj)
            {
                if (counter < obj.Count-1)
                {
                    json += JsonConvert.SerializeObject(item, Formatting.Indented) + ",";
                }
                else
                    json += JsonConvert.SerializeObject(item, Formatting.Indented) + "\n]";

                counter++;
            }

            File.WriteAllText(Environment.CurrentDirectory + @"\data.json", json);
        }


    }

}

