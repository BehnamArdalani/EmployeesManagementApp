using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Classes
{
    internal class Person
    {
        private string id;
        private string name;
        private int age;

        public Person(string id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public override string ToString()
        {
            return Id + "\t\t" + Name + "\t" + Age;
        }
    }

}
