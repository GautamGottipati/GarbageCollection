using System;

namespace UsingProject
{
    public class Class1 : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Releasing all resources . . .");
        }
        public void DoSomeTask()
        {
            Console.WriteLine("Starting Task . . .");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Doing Task");
            }
        }
    }
}
