using System;

namespace generic_type_compare
{
    internal class New<T>
    {
        public bool compare(T a, T b)  //<T> means Type of data due to this we can compare same type of any data
        {
            if (a.Equals(b))
            {
                return true;
            }
            else return false;
        }
        public void Add(T a, T b)  //comming addition and subtraction etc methods we again assign these values dynamically 
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
    }
    class program
    { 
        static void Main(string[] args)
        {
            New<int> n = new New<int>();
            n.Add(4, 6);
            
            
        }
    }
}
