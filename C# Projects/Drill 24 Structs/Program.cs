using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_24_Structs
{
    class Program
    {
        static void Main(string[] args)
        {

            Number number = new Number()
            {
                Amount = new decimal()
            };
            number.Amount = 5.5m;

            Console.WriteLine(number.Amount);
            Console.ReadLine();


        }
    }
}
