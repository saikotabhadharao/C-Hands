using System;
using System.Collections;

namespace hashtable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("name", "kota");
            ht.Add("gender", "male");
            ht.Add("age", 20);
            ht.Add("father", "mavullingam");
            ht.Add("mother", "peddintlamma");

            foreach(object key in ht.Keys)
            {
                Console.WriteLine(key+":"+ht[key]);
            }
        }
    }
}
