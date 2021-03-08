using System;
using System.Collections.Generic;

namespace Drill_10_Arrays_and_lists
{
    class Program
    {
        static void Main()
        {

            string[] name = { "James", "Albert", "Daniel", "Ashley" };
            Console.WriteLine("Please select a number from 0 to 3:");
            int userEntry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name[userEntry]);
            Console.ReadLine();



            int[] number = { 25, 50, 75, 100 };
            Console.WriteLine("Please select a number from 0 to 3:");
            int userEntry2 = Convert.ToInt32(Console.ReadLine());
            switch (userEntry2)
            {
                case 0:
                    Console.WriteLine(number[0]);
                    break;

                case 1:
                    Console.WriteLine(number[1]);
                    break;
                case 2:
                    Console.WriteLine(number[2]);
                    break;
                case 3:
                    Console.WriteLine(number[3]);
                    break;
                default:
                    Console.WriteLine("You've entered an invalid number...");
                    break;

            }
            Console.ReadLine();

            List<string> personNames = new List<string>();
            personNames.Add("Maddie");
            personNames.Add("Brooke");
            personNames.Add("Daniel");
            personNames.Add("Samantha");

            Console.WriteLine("Please select a number from 0 to 3:");
            int userEntry3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(personNames[userEntry3]);
            Console.ReadLine();




        }
    }
}
