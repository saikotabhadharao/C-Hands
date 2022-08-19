using System;
using System.Threading;

namespace multiThread_with_parameterized_delegate
{
    internal class Program
    {
        //
        public static void Test1(object max)
        {
            int n = Convert.ToInt32(max);
            for(int i=1;i<=50;i++)
            {
                Console.WriteLine("Test1-"+i);
            }
        }
        static void Main(string[] args)
        {
            //Delegate method declaration
            //ParameterizedThreadStart obj = new ParameterizedThreadStart(Test1);
            //ParameterizedThreadStart obj = Test1;

            //Delegate method declaration using Anonymous
           // ParameterizedThreadStart obj = delegate (object num) { Test1(num); };

            //Delegate method declaration using Lambda
            ParameterizedThreadStart obj = (num) => Test1(num);
            Thread t1 = new Thread(obj);
            t1.Start(50);
           
        }
    }
}
