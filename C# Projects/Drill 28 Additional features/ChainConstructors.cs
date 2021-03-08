using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_28_Additional_features
{
    public class ChainConstructors
    {
        public ChainConstructors(string name) : this(name, 17)
        {

        }
        public ChainConstructors(string name, int age)
        {
            Name = name;
            Age = age;
            
        }
        public string Name { get; set; }
        public int Age { get; set; }



    }
}
