using System;
using System.Collections.Generic;
using System.Text;

namespace UsingProject
{
    class Class2
    {
        public static void Main(string[] args)
        {
            Console.Title = "Use of Using Keyword";
            #region Case - 1
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
            #region Case 2
            using (Class1 c1 = new Class1())
            {
                c1.DoSomeTask();
            }
            #endregion
            Console.WriteLine();
        }
    }
}
