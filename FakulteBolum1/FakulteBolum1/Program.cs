using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakulteBolum1
{
    class Program
    {
        static void Main(string[] args)
        {

            Run1();

            Run2();

            Run3();
            Console.ReadKey();


        }
        private static void Run1()
        {
            Department department1 = new Department("Bilgisayar Mühendisliği");
            Department department2 = new Department("Elektirk Elektornik Mühendisliği");
            Department department3 = new Department("Çevre Mühendisliği");


            Queue obj = new Queue(5);


            Student s1 = new Student("202013709043", "Yiğitcan", "Serfiçe", department1);
            Student s2 = new Student("202013709050", "Cem", "Karaca", department1);
            Student s3 = new Student("202013709071", "Umut", "Katib", department1);
            Student s4 = new Student("201713704059", "Selin", "Kaya", department2);
            Student s5 = new Student("201813709011", "Simge", "Çalış", department3);

            obj.Enqueue(s1);
            obj.Enqueue(s2);
            obj.Enqueue(s3);
            obj.Enqueue(s4);
            obj.Enqueue(s5);


            DataToJson.ToJson(obj);
            DataFromJson.FromJson();

        }

        private static void Run2()
        {
            Course c1 = new Course("Nesneye Yönelik Programlama");
            Course c2 = new Course("Makine Öğrenmesi");
            Course c3 = new Course("Veri Yapıları Ve Algoritmalar");
            Student s1 = new Student("202013709043", "Yiğitcan", "Serfiçe", c1);
            Student s2 = new Student("202013709050", "Cem", "Karaca", c1);
            Student s3 = new Student("202013709071", "Umut", "Katib", c2);
            s1.AddCourse(c2);
            s1.AddCourse(c3);
            c1.Print();
            c2.Print();
            s1.Print();
            s2.Print();
            s3.Print();


        }

        private static void Run3()
        {
            Faculty faculty = new Faculty("Mühendislik");
            faculty.AddDepartment(new Department("Bilgisayar Mühendisliği"));
            faculty.AddDepartment(new Department("Elektrik-Elektronik Mühendisliği"));
            faculty.AddDepartment(new Department("Yazılım Mühendisliği"));
            faculty.Print();
        }
    }
}

