using System;

namespace anonymous_function
{
    public delegate void addDelegate(int a, int b);         //void type delegate declaration
    public delegate int multi(int a, int b);                //return type delegate declaration
    internal class Program
    {
        static void Main(string[] args)
        {
            //anonimous function
            //the function with method body without mwthod name is called anonymous function
            //in anonymous function keyword delegate,and delegate method declaration is mandatory
            addDelegate add = delegate (int a, int b)           //anonymous function contains method logic only
            {
                Console.WriteLine(a+b);
            };
            
            multi mul = delegate (int a, int b)                 //anonymous function contains method logic
              {
                  return a * b;
              };
            add(5, 7);
            Console.WriteLine(mul(6,8));

        }
       /* public static void add(int a,int b)
        {
            Console.WriteLine(a+b);
        }*/
    }
}
