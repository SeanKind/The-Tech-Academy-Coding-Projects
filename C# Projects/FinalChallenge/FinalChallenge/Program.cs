using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dB = new CodeFirst())
            {
                var bottle = new WaterBottle();
                bottle.Oz = 64;
                bottle.Color = "White";
                bottle.Brand = "Hydroflask";
                bottle.Height = 8;
                bottle.Width = 4;
                dB.WaterBottles.Add(bottle);
                dB.SaveChanges();
                Console.WriteLine(bottle.Brand);
            }

            

        }
    }
}
