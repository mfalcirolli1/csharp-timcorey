using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Não se prender diretamente às classes

            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new ExecutiveModel {FirstName = "Matheus", LastName = "Falcirolli"},
                new ManagerModel {FirstName = "Joice", LastName = "Duarte"},
                new PersonModel {FirstName = "Luke", LastName = "Skywalker"},
                new PersonModel {FirstName = "Tobby", LastName = "Esponja"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} | Is Manager? {emp.IsManager} | Is Executive? {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}
