using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Drill_26_File.IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string entry = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Sean\Documents\GitHub\The-Tech-Academy-C-Sharp-Drills\drill26.txt", entry);
            Console.WriteLine(File.ReadAllText(@"C:\Users\Sean\Documents\GitHub\The-Tech-Academy-C-Sharp-Drills\drill26.txt"));
            Console.ReadLine();




        }
    }
}
