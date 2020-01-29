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
            
            // Implementation of Try and Finally ,In this 
            // we need to call Dispose method explicitly in the finally block

            #region Try/Finally and IDisposable
            DispImpelmentation explicitDispose = new DispImpelmentation();
            try
            {
                explicitDispose.DoSomeTask();
            }
            finally
            {
                explicitDispose.Dispose();
            }
            #endregion
            
            Console.WriteLine("Entering Case 2 ===========>Using Block Example");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("-Generation of C is : " + GC.GetGeneration(explicitDispose));
            #region GC.Collect
            GC.Collect(0);
            #endregion
            
            // Implementation of Using block , In this the Dispose method is called implicitly

            #region Using Block
            using (DispImpelmentation implicitDispose = new DispImpelmentation())
            {
                implicitDispose.DoSomeTask();
                Console.WriteLine("Generation of C1 is : " + GC.GetGeneration(implicitDispose));
            }
            Console.WriteLine("Generation of C is : " + GC.GetGeneration(explicitDispose));
            Console.WriteLine("Garbage Collection in Generation 0 is: " + GC.CollectionCount(0));
            #endregion

            // Creating Constructor and Destructor and check if Finalize is created 
            // When destructor is called in ILDASM

            #region Constructor and destructor
            Console.WriteLine("Constructor and Destructor part . . .");
            GCExample constClass = new GCExample();
            #endregion
            Console.ReadKey();
        }
    }
}
