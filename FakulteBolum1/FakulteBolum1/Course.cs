using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakulteBolum1
{
    class Course
    {
        public List<Student> Students { get; private set; } = new List<Student>();

        public string Name { get; set; }

        public Course(string name) => Name = name;

        public Course(string name, Student student) : this(name) => AddStudent(student);

        public void AddStudent(Student student)
        {
            if (Students.Exists(s => s.No == student.No)) return;

            Students.Add(student);

        }

        public bool Remove(Student student) => Students.RemoveAll(s => s.No == student.No) == 1;

        public void Print()
        {
            if (Students.Count > 0)
            {
                Console.WriteLine("\n{0} Dersini Alan Öğrenciler", Name);
                Console.WriteLine(string.Concat("\n", new String('-', Name.Length + 24), "\n"));
            }

            foreach (var item in Students)
            {
                Console.WriteLine("Öğrenci No ........: {0}", item.No);
                Console.WriteLine("Öğrenci Adı .......: {0}", item.Name);
                Console.WriteLine("Öğrenci Soyadı ....: {0}", item.Surname);
                foreach (var item2 in item.Courses)
                    Console.WriteLine("Ders Adı ..........: {0}", item2.Name);
                Console.WriteLine();
            }
        }
    }
}
