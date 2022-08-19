using System;

namespace extensions
{
    //the extension method should contain the static key word so the method in that class also contain the static
    //the extension method contain the parameter that is "this<class name and identifier>" 
    //this parameter refers to  that class and extension to it
    internal class Program
    {
        static void Main(string[] args)
        {
           /* NormalMethod normal = new NormalMethod();
            normal.test1("kota");       // this is calling from NormalMethod class
            normal.test2("sai");        // this is calling from NormalMethod class
            normal.test3("ande");   */    //this is calling from Extension method class
            int i = 5;
            int fact=i.Factorial();
            Console.WriteLine($"fctorial of the number is {fact}");
            string str = "ANDE KOTASAI";
            Console.WriteLine(str.ToProper());
        }
    }
}
