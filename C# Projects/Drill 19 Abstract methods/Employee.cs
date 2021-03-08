using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_19_Abstract_methods
{
    class Employee : Person
    {

        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
            Console.ReadLine();
        }




    }
}
