using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingPro
{
    class GCExample
    {
        public GCExample()
        {
            Console.WriteLine("Calling class2 constructor . . .");
        }
        ~GCExample()
        {
            Console.WriteLine("Calling class2 Destructor . . .");
        }
    }
}
