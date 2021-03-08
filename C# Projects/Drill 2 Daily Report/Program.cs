using System;


namespace Drill_2_Daily_Report
{
    class Program
    {
        static void Main()
        {
            string courseName;
            int pageNumber;
            bool helpWith;
            string posExp;
            string feedback;
            int hoursStudied;



            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            courseName = Console.ReadLine();

            Console.WriteLine("What page number?");
            pageNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            helpWith = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            posExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            hoursStudied = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();


        }
    }
}
