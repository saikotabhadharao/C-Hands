using System;

namespace arrays
{
    internal class Program
    {
        static int[,] matrix =
         {
             {1,2,3},
             {4,5,6},
             {7,8,9},
             {6,6,3}
         };

       /* static int[,,] matrix =
        {
            {
                {1,2,3},
                {3,4,5}
            },
            {
                {2,3,4},
                {5,6,7}
            },
            {
                {6,7,8},
                {7,6,6}
            }
        };*/
       

        static void Main(string[] args)
        {
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
           

        }
    }
}
