using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Classes
{
    internal static class Store
    {
        private static List<Employee> employees = new List<Employee>();

        public static void Insert(Employee emp)
        {
            employees.Add(emp);
        }

        public static void Delete(string id)
        {
            bool isFound = false;

            foreach (Employee emp in employees)
            {
                if (emp.Id.Trim().ToUpper() == id.Trim().ToUpper())
                {
                    Message.Warning("Deleting...");
                    Header();

                    Message.Warning(emp.ToString());
                    employees.Remove(emp);
                    Message.Success("Deleted successfully!");
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Message.Danger("Employee Not Found!");
            }
        }

        public static void Update(string id)
        {
            bool isFound = false;
            foreach (Employee emp in employees)
            {
                if (emp.Id.Trim().ToUpper() == id.Trim().ToUpper())
                {
                    Message.Warning("Updating... ");

                    Header();
                    Message.Warning(emp.ToString());

                    /*
                    Console.Write($"Employee old name {emp.Name}, enter new name: ");
                    emp.Name = Console.ReadLine();
                    Console.Write($"Employee old age {emp.Age}, enter new age: ");
                    emp.Age = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Employee old department {emp.Department}, enter new department: ");
                    emp.Department = Console.ReadLine();
                    */
                    Console.Write($"Employee old baseSalary {emp.BaseSalary}, enter new baseSalary: ");
                    emp.BaseSalary = Convert.ToDouble(Console.ReadLine());
                    Console.Write($"Employee old comission {emp.Comission}, enter new comission: ");
                    emp.Comission = Convert.ToDouble(Console.ReadLine());
                    Console.Write($"Employee old lastAmountSold {emp.LastAmountSold}, enter new lastAmountSold: ");
                    emp.LastAmountSold = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("Updated successfully!");
                    isFound = true;

                    Header();
                    Message.Warning(emp.ToString());

                    break;
                }
            }
            if (!isFound)
            {
                Message.Danger("Employee Not Found!");
            }
        }

        public static void QueryById(string id)
        {
            bool isFound = false;

            Header();

            foreach (Employee emp in employees)
            {
                if(emp.Id.Trim().ToUpper() == id.Trim().ToUpper())
                {
                    Message.Warning(emp.ToString());
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Message.Danger("Employee Not Found!");
            }
        }

        public static void QueryByDepartment(string department)
        {
            bool isFound = false;

            Header();

            foreach (Employee emp in employees)
            {
                if (emp.Department.Trim().ToUpper() == department.Trim().ToUpper())
                {
                    Message.Warning(emp.ToString());
                    isFound = true;
                }
            }
            if (!isFound)
            {
                Message.Danger("Employee Not Found!");
            }
        }

        public static void Query()
        {
            bool isFound = false;

            Header();

            foreach (Employee emp in employees)
            {
                Message.Warning(emp.ToString());
                isFound = true;
            }
            if (!isFound)
            {
                Message.Danger("Employee List is Empty!");
            }            
        }

        public static void AverageSalary()
        {
            bool isFound = false;
            double sumSalaries = 0;
            
            foreach (Employee emp in employees)
            {
                sumSalaries += emp.Salary();
                isFound = true;
            }
            if (!isFound)
            {
                Message.Danger("Employee List is Empty!");
            }
            else
            {
                Message.Warning("The average of salaries: " + sumSalaries / employees.Count); 
            }
        }

        public static void AverageSalary(string department)
        {
            bool isFound = false;
            double sumSalaries = 0;
            int countSalaries = 0;

            foreach (Employee emp in employees)
            {
                if (emp.Department.Trim().ToUpper() == department.Trim().ToUpper())
                {
                    sumSalaries += emp.Salary();
                    countSalaries++;
                    isFound = true;
                }
            }
            if (!isFound)
            {
                Message.Danger("Employee List is Empty!");
            }
            else
            {
                Message.Warning("The average of department " + department + " salaries: " + sumSalaries / countSalaries);
            }
        }

        private static void Header()
        {
            Message.Warning("\nID\t\tNAME\t\tAGE\t\tDEPT\t\tSALARY");
            Message.Warning("-----------------------------------------------------------------------------");
        }
    }
}
