using System;

namespace index_concept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employe emp = new employe(101,40000,"kota", "579596", "hyderabad");
            //employe emp = new employe();
            Console.WriteLine(emp[0]);
            Console.WriteLine(emp[1]);
            Console.WriteLine(emp[2]);
            Console.WriteLine(emp[3]);
            Console.WriteLine(emp[4]);

            emp[0] = 202;
            emp[4] = "bangulur";

            Console.WriteLine(emp[0]);
            Console.WriteLine(emp[4]);

            emp["id"] = 505;
            emp["salary"] = 40560;
            Console.WriteLine(emp["id"]);
            Console.WriteLine(emp["salary"]);
        }
    }
}
