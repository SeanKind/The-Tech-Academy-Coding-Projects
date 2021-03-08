using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Drill_27_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            TimeSpan plusHours = new TimeSpan(number, 0, 0);
            DateTime nowPlusHours = dateTime.Add(plusHours);
            Console.WriteLine(nowPlusHours);
            Console.ReadLine();




        }
    }
}
