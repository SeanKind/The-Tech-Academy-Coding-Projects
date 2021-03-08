using System;

namespace Drill_3_Math_User_Input
{
    class Program
    {
        static void Main()
        {
            int multiply;
            int mulTotal;

            int addition;
            int addTotal;

            double division;
            double divTotal;

            int greaterThan;
            bool size;

            int remainder;
            int remTotal;



            Console.WriteLine("Please enter a number: ");
            multiply = Convert.ToInt32(Console.ReadLine());
            mulTotal = 50 * multiply;
            Console.WriteLine("Your number multiplied by 50: " + mulTotal);

            Console.WriteLine("Please enter another number: ");
            addition = Convert.ToInt32(Console.ReadLine());
            addTotal = 25 + addition;
            Console.WriteLine("Your number with 25 added to it: " + addTotal);

            Console.WriteLine("Please enter another number: ");
            division = Convert.ToDouble(Console.ReadLine());
            divTotal = division / 12.5;
            Console.WriteLine("Your number divided by 12.5: " + divTotal);

            Console.WriteLine("Please enter another number: ");
            greaterThan = Convert.ToInt32(Console.ReadLine());
            if (greaterThan > 50)
            {
                size = true;
            }
            else
            {
                size = false;
            }
            Console.WriteLine("50 is less than the number you selected: " + size);

            Console.WriteLine("Please enter another number: ");
            remainder = Convert.ToInt32(Console.ReadLine());
            remTotal = remainder % 7;
            Console.WriteLine("The remainder of your number divided by 7: " + remTotal);
            Console.ReadLine();


        }
    }
}
