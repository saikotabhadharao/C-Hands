using System;

namespace difference_between_finallymethod_and_end_statement
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
                if (y == 1)
                {
                    return;
                }
                int z = x / y;
                Console.WriteLine($"the result is {z}");
            }
            /*catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (OverflowException ex2)
            {
                Console.WriteLine(ex2.Message);
            }*/
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("the code in the final block is executed");
            }
            Console.WriteLine("the end of the code is executed");

        }
      
            

    }
}
