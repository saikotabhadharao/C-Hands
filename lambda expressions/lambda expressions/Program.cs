using System;

namespace lambda_expressions
{
    public delegate void AddDelegate(double a, double b);                   //delegate declaration 
    public delegate double DivDelegate(double a, double b);                 //delegate declaration
    internal class Program
    {
        static void Main(string[] args)
        {
         
            // lambda,anonymous functions are part of the delegate
            //these expresions are used to simplify the code that means no need to define the method name
            //in anonymous function we need to declare the types of parameters we passed
            //but comming to lambda no need to declare the parameter types
            //in lambda we are using => this expression

            AddDelegate add = (a, b) =>                                     //lambda expression(no need to declare the parameter type
            {
                Console.WriteLine("sum is :" + a + b);
            };
            DivDelegate div = (a, b) =>
            {
                return (a / b);
            };
            add(5, 6);
            Console.WriteLine("division value :"+div(8,6));
        }
    }
}
