using System;

namespace exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exceptions are two types
              1.system exception => the "ELR" is throw the exception message
                                 => "ELR" is the instance of the class.this class contain some default messages related to that exception

              2.Application exception => In this exception the user or developer can throw the own exceptions

             */

            //SYSTEM EXCEPTION EXAMPLE CODE
            try                         //in this method it try to executes the method body. if any runtime rises then the "ELR" throws
            {
                Console.WriteLine("ENTER THE FIRST NUMBER");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ENTER THE SECOND NUMBER");
                int Y = Convert.ToInt32(Console.ReadLine());
                int z = x / Y;
                Console.WriteLine($"the result is {z}");
            }
            catch(DivideByZeroException ex1)            //thrown runtime error is catch it  and shows the message
            {
                Console.WriteLine(ex1.Message);         // In this we can write our own message also

            }
            catch(FormatException ex2)                  // format exception =>if we need int value but if you give string or float value then it is comes under format exception
            {
                Console.WriteLine("enter valid format");    //Console.WriteLine(ex2.Message);
            }
            catch(OverflowException ex3)                   //OverFlow Exception =>if you give 8888888888888 like this it comes under OverFlow exception
            {
                Console.WriteLine(ex3.Message);
            }
            catch(Exception ex)                         //this is default exception that means other than above exception it comes into default exception
            {
                Console.WriteLine(ex.Message);
            }
            finally                                         //The statements in the finally method is executed every time
            {
                Console.WriteLine("the statement in the finally block is executed");
            }

            Console.WriteLine("end of the program is executed");  //this statement some times doesn't executed like if the try method having return statemnt at the returning this statement and catch methods are not exected.but finally method is executed at that time also.

        }
    }
}
