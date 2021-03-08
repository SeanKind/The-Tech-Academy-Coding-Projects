using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_23_Enums
{
    class Program
    {
        public enum daysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main()
        {

            
            Console.WriteLine("Please enter a day of the week, starting with a capital letter: ");
            string entry = Console.ReadLine();

            try
            {
                Console.WriteLine(Enum.Parse(typeof(daysOfTheWeek), entry));
                    
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week, with a capital letter");
                    
            }
            finally
            {
                Console.ReadLine();
            }
            



        }
    }
}
