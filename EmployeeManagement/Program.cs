using EmployeeManagement.Classes;
using System;

namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message.Warning("\nWelcome to the Employee Management System!\n");

            // Adding Sample Data:
            Menu.AddEmployee(new Employee("68319", "KAYLING ", 61, "FINANCE ", 6000, 0, 0));
            Menu.AddEmployee(new Employee("66928", "BLAZE ", 42, "FINANCE ", 2750, 0.1, 5000));
            Menu.AddEmployee(new Employee("67832", "CLARE ", 21, "FINANCE ", 2550, 0.1, 4000));
            Menu.AddEmployee(new Employee("65646", "MANAGER ", 33, "FINANCE ", 6000, 0.05, 3000));
            Menu.AddEmployee(new Employee("67858", "SCARLET ", 37, "AUDIT ", 3000, 0.07, 3300));
            Menu.AddEmployee(new Employee("63679", "FRANK ", 28, "AUDIT ", 2500, 0.1, 2500));
            Menu.AddEmployee(new Employee("64989", "SANDRINE", 41, "MARKETING ", 2000, 0.08, 1500));
            Menu.AddEmployee(new Employee("65271", "ADELYN ", 55, "MARKETING ", 3000, 0.09, 7300));
            Menu.AddEmployee(new Employee("66564", "WADE ", 30, "MARKETING ", 4000, 0.12, 4200));
            Menu.AddEmployee(new Employee("68454", "MADDEN ", 44, "MARKETING ", 2500, 0.11, 3400));
            Menu.AddEmployee(new Employee("68736", "TUCKER ", 35, "PRODUCTION", 3400, 0.13, 2500));
            Menu.AddEmployee(new Employee("69000", "ADNRES ", 22, "PRODUCTION", 2800, 0.1, 3450));
            Menu.AddEmployee(new Employee("69324", "MARKER ", 18, "PRODUCTION", 2900, 0.15, 7310));

            // Starting the Menu:
            Menu.Start();

        }
    }
}
