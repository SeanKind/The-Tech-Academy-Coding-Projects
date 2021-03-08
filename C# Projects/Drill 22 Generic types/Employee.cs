using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_22_Generic_types
{
    class Employee<T> : Person
    {
        public int Id { get; set; }

        public List<T> things { get; set; }

        



    }
}
