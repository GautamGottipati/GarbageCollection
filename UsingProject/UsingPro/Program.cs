using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Use of Using Keyword";
            #region Try/Finally and IDisposable
            Class1 c = new Class1();
            try
            {
                c.DoSomeTask();
            }
            finally
            {
                c.Dispose();
            }
            #endregion
            Console.WriteLine("Entering Case 2 ===========>");
            Console.WriteLine("-Generation of C is : " + GC.GetGeneration(c));
            #region GC.Collect
            GC.Collect(0);
            #endregion
            #region Using Block
            using (Class1 c1 = new Class1())
            {
                c1.DoSomeTask();
                Console.WriteLine("Generation of C1 is : " + GC.GetGeneration(c1));
            }
            Console.WriteLine("Generation of C is : " + GC.GetGeneration(c));
            Console.WriteLine("Garbage Collection in Generation 0 is: " + GC.CollectionCount(0));
            #endregion
            #region Constructor and destructor
            Console.WriteLine("Constructor and Destructor part . . .");
            Class2 c2 = new Class2();
            #endregion
            Console.ReadKey();
        }
    }
}
