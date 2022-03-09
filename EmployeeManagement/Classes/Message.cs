using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Classes
{
    internal class Message
    {
        private static void Print(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void Danger(string message)
        {
            Print(message, ConsoleColor.Red);
        }
        public static void Warning(string message)
        {
            Print(message, ConsoleColor.Yellow);
        }
        public static void Success(string message)
        {
            Print(message, ConsoleColor.Green);
        }
    }
}
