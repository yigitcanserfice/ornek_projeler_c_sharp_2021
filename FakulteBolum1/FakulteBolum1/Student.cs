using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace FakulteBolum1
{
    class Student
    {
        public string No { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public Department Department { get; set; }

        public System.Collections.Generic.List<Course> Courses { get; private set; } = new System.Collections.Generic.List<Course>();
        [JsonConstructor]

        public Student(string no, string name, string surname)
        {
            No = no;
            Name = name;
            Surname = surname;
        }

        public Student(string no, string name, string surname, Department department) : this(no, name, surname) => this.Department = department;

        public Student(string no, string name, string surname, Course course) : this(no, name, surname)
        {
            Courses.Add(course);
            course.AddStudent(this);

        }

        public void AddCourse(Course course)
        {
            if (Courses.Exists(c => c.Name == course.Name)) return;
            course.Students.Add(this);
            Courses.Add(course);

        }

        public bool RemoveCourse(Course course) => Courses.RemoveAll(c => c.Name == course.Name) == 1;

        public void Print()
        {
            if (Courses.Count > 0)
            {
                Console.WriteLine("{0} Numaralı Öğrencinin Aldığı Dersler", No);
                Console.WriteLine(string.Concat("\n", new String('-', No.Length + 35), "\n"));
            }
            foreach (var item in Courses)
                Console.WriteLine("Ders Adı  .......... : {0}", item.Name);



        }
    }
}
