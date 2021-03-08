using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_15_Multiple_Parameters
{
    class optional
    {
        public static int Numbers(int first, int second = 0)
        {
            first = first * 10;
            int final = first + second;
            return final;
        }






    }
}
