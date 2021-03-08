using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_13_Class_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mathParameter.MethodOne(userNumber));
            Console.WriteLine(mathParameter.MethodTwo(userNumber));
            Console.WriteLine(mathParameter.MethodThree(userNumber));

            Console.ReadLine();

        }
    }
}
