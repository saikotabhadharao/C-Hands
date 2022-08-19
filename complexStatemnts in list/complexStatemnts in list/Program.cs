using System;
using System.Collections.Generic;

namespace complexStatemnts_in_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            GenericType gen1 = new GenericType("kota", 20, "hyderabad");
            GenericType gen2 = new GenericType("sai", 18, "bangalur");
            GenericType gen3 = new GenericType("Nagendra", 22, "chennai");
            List<GenericType> li = new List<GenericType> { gen1, gen2, gen3 };
          /*  li.Add(gen1);
            li.Add(gen2);
            li.Add(gen3);*/

            foreach(GenericType gen in li)
            {
                Console.WriteLine(gen.name+" "+gen.age+" "+gen.location);
            }

           

        }
    }
}
