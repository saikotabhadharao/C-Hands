using System;
using System.Threading;

namespace multiThread_with_ThreadStart_delegate
{
    internal class Program
    {
        static void Test1()
        {
            for(int i=1;i<50;i++)
            {
                Console.WriteLine("Test1-"+i);
            }
        }
        static void Test2()
        {
            for (int i = 1; i < 50; i++)
            {
                Console.WriteLine("Test2-" + i);
            }
        }
        static void Main(string[] args)
        {
            //Thread calling with delegate
           // ThreadStart obj1 = new ThreadStart(Test1);
            //ThreadStart obj1 = Test1;
            //ThreadStart obj1 = delegate () { Test1(); };
            ThreadStart obj1 = () => Test1();
            
            Thread t1 = new Thread(obj1);
           
            t1.Start();
            
            

           
        }
    }
}
