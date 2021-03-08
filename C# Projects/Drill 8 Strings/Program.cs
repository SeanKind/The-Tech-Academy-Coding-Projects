using System;
using System.Text;


namespace Drill_8_Strings
{
    class Program
    {
        static void Main()
        {
            string part1 = "Hello!";
            string part2 = " My name is ";
            string part3 = "Sean!";
            Console.WriteLine(part1 + part2 + part3);

            string lower = "this string is now capitalized";
            Console.WriteLine(lower.ToUpper());

            StringBuilder paragraph = new StringBuilder("Once there was a prince.");
            paragraph.Append(" He was very tall.");
            paragraph.Append(" He was also very brave.");
            paragraph.Append(" Unfortunately, he died.");
            Console.WriteLine(paragraph);

            Console.ReadLine();




        }
    }
}
