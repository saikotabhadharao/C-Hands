using System;

namespace delegate_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Generic Delegate types  => 1.func   ,2.action  , 3.Predicate
            1.func delegate =>if the delegate returns any data type  then we can func delegate. syntax:func<in1,in2,in3,___,in16,out1)
            2.action => if the delegate doesn't return any thing we can use action delegate. syntax:action<in1,in2____in16>
            3.predicate => if the return type of delegate is boolean then we can use predicate. syntax: predicate<in1>
             due to anonymous delegates no need to write the methods
             */
            // inputs(int,double,float) => output(double)
            Func<int,double,float,double> obj1=(a,b,c) => a + b + c;
            Console.WriteLine(obj1(2,5,7));

            //input(int,double,float)
            Action<int, double, float> obj2 = (a, b, c) => Console.WriteLine(a+b+c);
            obj2(3, 5, 8);

            Predicate<string> obj3 = (name) =>
              {
                  if (name.Length > 5)
                  {
                      return true;
                  }
                  return false;
              };
            Console.WriteLine(obj3("kota"));



        }
    }
}
