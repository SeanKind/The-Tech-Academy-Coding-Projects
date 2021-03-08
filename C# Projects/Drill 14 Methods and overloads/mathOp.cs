using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_14_Methods_and_overloads
{
    class mathOp
    {
        public static int InputOne(int firstNumber)
        {
            firstNumber = firstNumber * 10;
            return firstNumber;
        }

        public static decimal InputOne(decimal secondNumber)
        {
            secondNumber = secondNumber * 100;
            return secondNumber;
        }

        public static int InputOne(string thirdNumber)
        {
            int thirdNumberInt = Convert.ToInt32(thirdNumber);
            thirdNumberInt = thirdNumberInt / 10;
            return thirdNumberInt;
        }



    }
}
