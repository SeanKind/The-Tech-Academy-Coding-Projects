using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_12_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 100, 20, 50 };

            

            try
            {
                Console.WriteLine("Please enter a number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numbers)
                {
                    int final = number / userNumber;
                    Console.WriteLine(number + " Divided by " + userNumber + " is: " + final);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Returning to the program");
                Console.ReadLine();
            }
            Console.WriteLine("Continuing the program");
            Console.ReadLine();




        }
    }
}
