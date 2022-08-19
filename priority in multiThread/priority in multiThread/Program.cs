using System;
using System.Threading;
using System.Threading.Tasks;
namespace priority_in_multiThread
{
    internal class Program
    {
        static long count1, count2;
        public static void IncrementCount1()
        {
            while(true)                     //infinite while loop
            {
                count1++;
            }
        }
        public static void IncrementCount2()
        {
            while(true)
            {
                count2++;
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);

            t1.Priority = ThreadPriority.Highest;           //it executes fast that means cpu provides maximum resources to this
            t2.Priority = ThreadPriority.Lowest;            //it executes slow that means cpu  provides minimum resources to this

            t1.Start(); t2.Start();
            Console.WriteLine("main thread go to sleep");
            Thread.Sleep(5000);
            Console.WriteLine("main thread wake up");

            t1.Abort();     //Abort is used break the infinite execution loop
            t2.Abort();

            t1.Join(); t2.Join();
            Console.WriteLine("count1 "+count1);
            Console.WriteLine("count2 "+count2);

        }
    }
}
