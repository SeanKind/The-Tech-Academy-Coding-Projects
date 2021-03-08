using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_28_Additional_features
{
    class Program
    {
        static void Main()
        {
            const string name = "Sean";
            Console.WriteLine(name);

            var newDict = new Dictionary<int, string>();

            ChainConstructors newCon = new ChainConstructors("Sean");
            Console.ReadLine();


        }
    }
}
