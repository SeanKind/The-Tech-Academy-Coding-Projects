using System;


namespace Drill_6_Package_Express
{
    class Program
    {
        static void Main()
        {
            int weight;
            int width;
            int height;
            int length;
            int totalDim;
            int Price;


            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight: ");
            weight = Convert.ToInt32(Console.ReadLine());

            if (weight < 50)
            {
                Console.WriteLine("Please enter the package width: ");
                width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height: ");
                height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length: ");
                length = Convert.ToInt32(Console.ReadLine());

                totalDim = width + height + length;
                if (totalDim > 50)
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express."); 
                }
                else
                {
                    Price = totalDim * weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + Price);
                    Console.WriteLine("Thank you.");
                }

            }
            else
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
            }
            Console.Read();



        }
    }
}
