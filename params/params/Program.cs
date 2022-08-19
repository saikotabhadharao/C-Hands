using System;

namespace param
{
    internal class Program
{
    static void Main(string[] args)
    {
            //int[] num = new int[] { 1, 2, 3, 4, 5, 6 };
            int min = FindMin(1,2,3,4,5,6);
            Console.Write($"my min value is{min}");
   
    }
    public static int FindMin(params int[] num)
        {
            int min = int.MaxValue;
            foreach(int i in num)
            {
                if(min>i)
                {
                    min = i;
                }
            }
            return min;
        }
   

   
}
}
