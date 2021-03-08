using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_29_More_exception_handling
{
    class Program
    {
        static void Main()
        {
            
            int userAge = 0;
            bool validAge = false;
            while (!validAge)
            {
                Console.WriteLine("What is your age?: ");
                try
                {
                    userAge = Convert.ToInt32(Console.ReadLine());
                    if (userAge == 0) throw new DivideByZeroException();
                    if (userAge < 0) throw new ArgumentOutOfRangeException();
                    validAge = true;
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter your age with numbers only.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Please enter an age greater than 0.");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Please enter a positive value for an age.");
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurred. Please enter a whole number.");
                }

            }
            var today = DateTime.Today;
            int yearOfBirth = 0;
            try
            {
                yearOfBirth = today.Year - userAge;
                if (yearOfBirth <= 0) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Your birth year is not within a realistic scope.\nYou are either dead or eternal, and at that point your birth year doesnt matter.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Is your birthday before todays date in the year? EX: If you were born on March 1st, enter Y.\n(Please answer Y/N): ");
            string beforeAfter = Console.ReadLine().ToLower();
            if (beforeAfter == "n") yearOfBirth--;
            Console.WriteLine("You were born in the year: {0}", yearOfBirth);
            Console.ReadLine();








        }
    }
}
