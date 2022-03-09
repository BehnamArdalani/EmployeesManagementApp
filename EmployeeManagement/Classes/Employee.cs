using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Classes
{
    internal class Employee:Person
    {
        private string department;
        private double baseSalary;
        private double comission;
        private double lastAmountSold;

        public Employee(string id, string name, int age, string department, double baseSalary, double comission, double lastAmountSold) : base(id, name, age)
        {
            Department = department;
            BaseSalary = baseSalary;
            Comission = comission;
            LastAmountSold = lastAmountSold;
        }

        public string Department { get => department; set => department = value; }
        public double BaseSalary { get => baseSalary; set => baseSalary = value; }
        public double Comission { get => comission; set => comission = value; }
        public double LastAmountSold { get => lastAmountSold; set => lastAmountSold = value; }

        public double Salary()
        {
            return Math.Round(BaseSalary + ( LastAmountSold * Comission),2);
        }

        public override string ToString()
        {
            return base.ToString() + "\t\t" + Department + "\t" + Salary().ToString();
        }
    }
}
