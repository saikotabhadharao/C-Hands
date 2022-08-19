using System;
using System.Threading;

namespace multithread1
{
    internal class Program
    {
        static void Test1()
        {
            for(int i=0;i<50;i++)
            {
                Console.WriteLine("Test1 - "+i);
            }
        }
        static void Test2()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Test2 - " + i);
            }

        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            t1.Start();
            t2.Start();
            
            
        }
    }
}
