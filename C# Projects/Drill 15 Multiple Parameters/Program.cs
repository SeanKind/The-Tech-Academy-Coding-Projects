using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_15_Multiple_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number (optional): ");
            int second;

            //Putting the optional parameter into a try catch incase of a format error with the user entry conversion. 
            //There probably is a simpler way to do this, however this is effective for its purpose.
            try
            {
                second = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(optional.Numbers(first, second));

            }
            catch
            {
                Console.WriteLine(optional.Numbers(first, second = 0));
            }
            finally
            {
                Console.ReadLine();
            }

            







        }
    }
}
