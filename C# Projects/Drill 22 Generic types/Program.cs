using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_22_Generic_types
{
    class Program
    {
        static void Main(string[] args)
        {


            Employee<string> stringThings = new Employee<string>()
            {
                things = new List<string> { "Apple ", "Blueberry ", "Cherry" }
            };
            Employee<int> intThings = new Employee<int>()
            {
                things = new List<int> { 5, 10, 15}
            };


            foreach (string item in stringThings.things)
            {
                Console.WriteLine(item + " ");
            }
            foreach (int item in intThings.things)
            {
                Console.WriteLine(item + " ");
            }

            Console.ReadLine();




        }
    }
}
