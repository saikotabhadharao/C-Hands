using System;
using System.Threading;

namespace lock_method_in_multiThread
{
    internal class Program
    {
        //two threads start at a time but due to lock method one thread wait until another complete the execution
        // if first thread completed the execution then the lock is give permission to execute the second thread
        public  void Test()
        {
            lock (this)
            {
                Console.Write("c sharp is a");
                Thread.Sleep(5000);
                Console.WriteLine("objective oriented programming language");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Thread t1 = new Thread(p.Test);
            Thread t2 = new Thread(p.Test);
            t1.Start();
            t2.Start();
            
        }
    }
}
