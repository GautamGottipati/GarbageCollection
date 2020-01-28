using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingPro
{
    class Class1 : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Releasing all resources . . .");
        }
        public void DoSomeTask()
        {
            Console.WriteLine("Starting Task . . .");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Doing Task");
            }
        }
    }
}
