using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_21_Overloaded_operators
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            bool equal;

            employee1.Id = 1;
            employee2.Id = 1;
            equal = employee1.Id == employee2.Id;


            Console.WriteLine("There are employees with the same id number: " + equal);
            Console.ReadLine();
            

            









        }
    }
}
