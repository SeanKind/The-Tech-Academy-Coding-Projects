using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_14_Methods_and_overloads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(mathOp.InputOne(firstNumber));
            Console.ReadLine();



            Console.WriteLine("Please enter a decimal: ");
            decimal secondNumber = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(mathOp.InputOne(secondNumber));
            Console.ReadLine();



            Console.WriteLine("Please enter a number: ");
            string thirdNumber = Console.ReadLine();
            Console.WriteLine(mathOp.InputOne(thirdNumber));
            Console.ReadLine();







        }
    }
}
