using System;
using System.Collections.Generic;

namespace dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, Object> dic = new Dictionary<string, Object>
            {
                {"name","kotasai" },
                {"age",20 },
                {"gender","male" }
            };
            foreach(string str in dic.Keys)
            {
                Console.WriteLine(str+" : "+dic[str]);
            }
            

        }
    }
}
