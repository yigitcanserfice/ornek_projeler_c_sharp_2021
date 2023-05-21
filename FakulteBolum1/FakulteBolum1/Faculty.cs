using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakulteBolum1
{
    class Faculty
    {
        public string Name { get; set; }

        private List<Department> Departments { get; set; } = new List<Department>();

        public Faculty(string name) => Name = name;

        public Faculty(string name, Department department) : this(name) => AddDepartment(department);

        public void AddDepartment(Department department)
        {
            if (Departments.Exists(d => d.Name == department.Name)) return;
            Departments.Add(department);
        }

        public bool RemoveDepartment(Department department) => Departments.RemoveAll(d => d.Name == department.Name) == 1;


        public void Print()
        {
            Console.WriteLine(string.Concat("\n", new String('-', Name.Length + 34), "\n"));
            Console.WriteLine("{0} Fakültesindeki Bölümlerin Listesi", Name);
            Console.WriteLine(string.Concat("\n", new String('-', Name.Length + 34), "\n"));
            foreach (var item in Departments)
                Console.WriteLine("{0}", item.Name);
        }
    }
}
