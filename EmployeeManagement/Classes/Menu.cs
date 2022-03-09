using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Classes
{
    internal static class Menu
    {
        public static void Start()
        {
            int selected = -1;
            do
            {

                Console.WriteLine("\n********** Main Menu: **********");
                Console.WriteLine("1. Search Employee by ID");
                Console.WriteLine("2. Edit Employee by ID");
                Console.WriteLine("3. Delete Employee by ID");
                Console.WriteLine("4. List All Employees");
                Console.WriteLine("5. List Employees by Department");
                Console.WriteLine("6. Average Employees Salaries");
                Console.WriteLine("7. Average Employees Salaries by Department");
                Console.WriteLine("8. Exit");

                Console.Write("Please select an option: ");
                selected = Convert.ToInt32(Console.ReadLine());

            } while (selected < 1 || selected > 8);


            switch (selected)
            {
                case 1:
                    SearchEmployee();
                    break;
                case 2:
                    EditEmployee();
                    break;
                case 3:
                    DeleteEmployee();
                    break;
                case 4:
                    AllEmployees();
                    break;
                case 5:
                    AllDepartmentEmployees();
                    break;
                case 6:
                    AverageSalary();
                    break;
                case 7:
                    AverageDepartmentSalary();
                    break;
                default:
                    Message.Warning("\nHave a good day! :)\n");
                    break;
            }
        }

        public static void AddEmployee(Employee employee)
        {
            Store.Insert(employee);
        }

        public static void SearchEmployee()
        {
            Console.Write("Please enter the employee id: ");
            string id = Console.ReadLine();
            Store.QueryById(id);

            Start();
        }

        public static void EditEmployee()
        {
            Console.Write("Please enter the employee id: ");
            string id = Console.ReadLine();
            Store.Update(id);

            Start();
        }

        public static void DeleteEmployee()
        {
            Console.Write("Please enter the employee id: ");
            string id = Console.ReadLine();
            Store.Delete(id);

            Start();
        }

        public static void AllEmployees()
        {
            Store.Query();
            Start();
        }

        public static void AllDepartmentEmployees()
        {
            Console.Write("Please enter the department: ");
            string department = Console.ReadLine();
            Store.QueryByDepartment(department);

            Start();
        }

        public static void AverageSalary()
        {
            Store.AverageSalary();

            Start();
        }

        public static void AverageDepartmentSalary()
        {
            Console.Write("Please enter the department: ");
            string department = Console.ReadLine();
            Store.AverageSalary(department);

            Start();
        }
                    

    }
}
