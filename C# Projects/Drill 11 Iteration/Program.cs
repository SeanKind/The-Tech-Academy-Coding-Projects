using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_11_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {

            //Asks user for input and saves it.Then it prints to the console what they've entered
            string[] userText = new string[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter a name to be saved: ");
                userText[i] = Console.ReadLine();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(userText[i]);
            }
            Console.ReadLine();


            //Infinte loop
            //for (int i = 1; i > 0; i++)
            //{
            //    Console.WriteLine("Loooooop");
            //}


            //Fixing the infinite loop, and < and <= operator determining whether to continue iterating 
            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine("We've fixed the loop!");
            }

            //User entering values to be searched in a list and print the corresponding index. Informs the user if there is no matching value in the list, and exits the loop if 
            //a match has been found
            List<string> cars = new List<string>() { "Mustang", "Cobra", "Ferrari" };
            Console.WriteLine("Please enter a vehicle");
            string userValue = Console.ReadLine();
            for (int i = 0; i < cars.Count; i++)
            {
                if (userValue == cars[i])
                {
                    Console.WriteLine("The index of that vehicle: " + i);
                    break;
                }
                else
                {
                    Console.WriteLine("It appears as though that vehicle is not in the list.");
                    break;
                }
            }

            //Looping through an array that has duplicate values and displays the index of the matching values. 
            string[] duplicate = { "Bob", "Sam", "James", "Bob", "Sam", "James", };
            Console.WriteLine("Please enter a name to search: ");
            string duplicateEntry = Console.ReadLine();

            for (int i = 0; i < duplicate.Count(); i++)
            {
                bool detected = false;
                if (duplicateEntry == duplicate[i])
                {
                    Console.WriteLine(i);
                    detected = true;


                }
                if ((detected == false) && (i == duplicate.Count() - 1))
                {
                    Console.WriteLine("You've entered a nonexistent name.");
                    break;
                }

            }


            // Foreach loop that determines if there is two identical strings in the list.
            List<string> identical = new List<string> { "Bob", "Sam", "James", "Bob", "Sam", "James", "Adam", "Danial", };
            List<string> identicalDuplicate = new List<string>();
            foreach (string name in identical)
            {
                
                if (identicalDuplicate.Contains(name))
                {
                    Console.WriteLine(name + " has appeared?: " + true);
                }
                else
                {
                    identicalDuplicate.Add(name);
                    Console.WriteLine(name + " has appeared?: " + false);

                }
                
                
            }
            





            Console.ReadLine();
        }
    }
}
