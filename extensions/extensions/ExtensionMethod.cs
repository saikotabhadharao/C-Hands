using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensions
{
    static class ExtensionMethod
    {
        public static void test3(this NormalMethod normal,string name)
        {
            Console.WriteLine($"the name of the test3 is {name}");
        }
        public static int Factorial(this Int32 x)
        {
            if(x==0 || x==1)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
        public static string ToProper(this string name)   // string str="ANDE KOTASAI" => name refers to "ANDE KOTASAI"
        {
            return name.ToLower();
        }
        
    }
}
