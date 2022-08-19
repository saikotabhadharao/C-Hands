
using System;
using System.Threading;

namespace join_method_in_multiThread
{
    internal class Program
    {
        static void Test1()
        {
            Console.WriteLine("Test1 start execution");
            for(int i=1;i<50;i++)
            {
                Console.WriteLine("test1 - "+i);
            }
            Console.WriteLine("Test1 ends execution");
        }
        static void Test2()
        {
            Console.WriteLine("Test2 start execution");
            for (int i = 1; i < 50; i++)
            {
                Console.WriteLine("test2 - " + i);
            }
            Console.WriteLine("Test2 ends execution");
        }
        static void Test3()
        {
            Console.WriteLine("Test3 start execution");
            for (int i = 1; i < 50; i++)
            {
                Console.WriteLine("test3 - " + i);
            }
            Console.WriteLine("Test3 ends execution");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread start execution");

            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start(); t2.Start(); t3.Start();
            // If you remove the join then the main thread execution ends before the child Thread Execution ends
            //If u are using join then the main thread ends after the child thread execution ends
            t1.Join(); t2.Join(); t3.Join();
            Console.WriteLine("Main thread ends execution");

        }
    }
}
