using System;

namespace Drill_4_Math_Comp_OP
{
    class Program
    {
        static void Main()
        {
            int firstRate;
            int firstHours;
            int secondRate;
            int secondHours;
            int firstWeekly;
            int firstYearly;
            int secondWeekly;
            int secondYearly;
            bool salaryComp;

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?: ");
            firstRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours a week do you work?: ");
            firstHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?: ");
            secondRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours a week do you work?: ");
            secondHours = Convert.ToInt32(Console.ReadLine());

            firstWeekly = firstRate * firstHours;
            firstYearly = firstWeekly * 52;

            secondWeekly = secondRate * secondHours;
            secondYearly = secondWeekly * 52;

            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(firstYearly);
            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(secondYearly);

            if (firstYearly > secondYearly)
            {
                salaryComp = true;
            }
            else
            {
                salaryComp = false;
            }
            Console.WriteLine("Does Person 1 make more money than person 2?: ");
            Console.WriteLine(salaryComp);

            Console.Read();
            

        }
    }
}
