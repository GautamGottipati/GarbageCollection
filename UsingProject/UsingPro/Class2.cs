using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingPro
{
    class Class2
    {
        public Class2()
        {
            Console.WriteLine("Calling class2 constructor . . .");
        }
        ~Class2()
        {
            Console.WriteLine("Calling class2 Destructor . . .");
        }
    }
}
