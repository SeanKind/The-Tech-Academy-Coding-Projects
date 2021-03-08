using System;

namespace Drill_7_Do_s_and_while_s
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Please guess a number: ");
            int value = Convert.ToInt32(Console.ReadLine());
            bool guess = value == 10;

            while (!guess)
            {
                switch (value)
                {
                    case 10:
                        Console.WriteLine("You've guessed correctly!");
                        guess = true;
                        break;

                    default:
                        Console.WriteLine("You've guessed incorrectly, please guess again: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.ReadLine();

            Console.WriteLine("Please guess a name: ");
            string name = Console.ReadLine();
            bool guess2 = name == "sean";

            do
            {
                switch (name)
                {
                    case "sean":
                        Console.WriteLine("Congrats! You guessed the name!");
                        guess2 = true;
                        break;

                    default:
                        Console.WriteLine("Unfortunately you have not guessed the name correctly, please try again: ");
                        name = Console.ReadLine();
                        break;

                }
            }
            while (!guess2);

            Console.ReadLine();

        }
    }
}
