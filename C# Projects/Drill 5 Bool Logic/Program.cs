using System;

namespace Drill_5_Bool_Logic
{
    class Program
    {
        static void Main()
        {
            int age;
            bool DUI;
            int speedTicket;

            bool ageCheck = false;
            bool duiCheck = false;
            bool ticketCheck = false;

            bool qualified = false;

            Console.WriteLine("What is your age?: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age > 15)
            {
                ageCheck = true;
            }

            Console.WriteLine("Have you ever had a DUI?: ");
            DUI = Convert.ToBoolean(Console.ReadLine());
            if (DUI == false)
            {
                duiCheck = true;
            }

            Console.WriteLine("How many speeding tickets do you have?: ");
            speedTicket = Convert.ToInt32(Console.ReadLine());
            if (speedTicket <= 3)
            {
                ticketCheck = true;
            }

            if (ageCheck && duiCheck && ticketCheck == true)
            {
                qualified = true;
            }
            Console.WriteLine("Qualified?: ");
            Console.WriteLine(qualified);
            Console.ReadLine();


        }
    }
}
