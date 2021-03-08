using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_17_Class_methods
{
    class example
    {
        public void IntOut(int number)
        {
            number = number / 2;
            Console.WriteLine(number);
            Console.ReadLine();


        }

        public static int NumberOut(out int numOut, int num = 1)
        {
            numOut = 0;
            for (int i = 0; i < num; i++)
            {
                numOut++;
            }

            return num;
        }

        public static string NumberOut(string Test)
        {
            Console.WriteLine("Please enter a name: ");
            Test = Console.ReadLine();
            return Test;
        }

    }
}
