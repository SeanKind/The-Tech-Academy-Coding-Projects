using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_20_Interfaces
{
    class Employee : Person, IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("WE'RE QUITTING NOW");
            Console.ReadLine();
        }
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
            Console.ReadLine();
        }


    }
}
