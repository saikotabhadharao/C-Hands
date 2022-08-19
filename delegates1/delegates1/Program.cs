using System;

namespace delegates1
{
    public delegate void Adddeligate(int x, int y);
    public delegate string combinedeligate(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            
            Adddeligate adding = new Adddeligate(Add);
            combinedeligate com = new combinedeligate(p.combine);
            //calling using deligates
            adding(7, 8);
            Console.WriteLine(com("kota"));

            //calling normally
            Add(3, 4);
            Console.WriteLine(p.combine("sai"));
        }
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public string combine(string name)
        {
            return "hello " + name;
        }

    }
   
}
