using System;

namespace interfacedemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            equate equal = new equate(10);
            equate equal1 = new equate(10);
           Console.WriteLine(equal.Equals(equal1));
        }
    }
}
