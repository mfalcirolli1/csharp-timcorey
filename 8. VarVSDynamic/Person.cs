using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarVSDynamic
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Hello {FirstName} {LastName}");
        }
    }
}
