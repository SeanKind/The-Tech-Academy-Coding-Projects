using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_17_Class_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Please enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            example example = new example();
            example.IntOut(number);




            int numOut;
            int num;
            Console.WriteLine("Number: ");
            numOut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Next Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(example.NumberOut(out numOut, num));
            Console.ReadLine();


            string Test = "Test";
            Console.WriteLine(example.NumberOut(Test));
            Console.ReadLine();



            electrostatic.Better();



        }
    }
}
