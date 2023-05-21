using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace FakulteBolum1
{
    class DataFromJson
    {
        public static void FromJson()
        {
            StreamReader reader = new StreamReader(Environment.CurrentDirectory + @"\data.json");
            string json = reader.ReadToEnd();

            List<Student> student = JsonConvert.DeserializeObject<List<Student>>(json);

            string x = "___________________________________________________________________________________";

            for (int i = 0; i < student.Count; i++)
            {
                Console.WriteLine(x + "\n");
                Console.WriteLine("Ad Soyad => " + student[i].Name + " " + student[i].Surname);
                Console.WriteLine("Öğrenci Numarası => " + student[i].No);
                Console.WriteLine("Bölümü => " + student[i].Department.Name);


                for (int j = 0; j < student[i].Courses.Count; j++)
                {
                    Console.WriteLine("Aldığı Dersler => " + student[i].Courses[j].Name);

                }
            }

            Console.WriteLine(x + "\n");

            reader.Close();


        }
    }
}
