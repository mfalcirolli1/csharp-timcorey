using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager accountVP = new Manager();

            accountVP.FirstName = "Matheus";
            accountVP.LastName = "Falcirolli";
            accountVP.CalculatePerHourRate(4);

            Employee emp = new Manager();

            emp.FirstName = "Joice";
            emp.LastName = "Duarte";
            emp.CalculatePerHourRate(4);

            Console.WriteLine($"{emp.FirstName} ->  ${emp.Salary}/hour");

            Console.ReadLine();

        }
    }
}
