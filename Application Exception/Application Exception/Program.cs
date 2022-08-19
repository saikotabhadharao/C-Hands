using System;

namespace Application_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the first number");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the second number");
                int y = Convert.ToInt32(Console.ReadLine());
                if(y%2!=0)
                {
                    ApplicationException ap = new ApplicationException("due to odd number");
                    throw ap;
                    //throw new ApplicationException("due to odd number");
                }
                int z = x / y;
                Console.WriteLine($"the result is {z}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           

        }
    }
}
