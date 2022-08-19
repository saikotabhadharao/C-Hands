using System;

namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //public member variable
             human myVolume = new human();
             myVolume.length = 7;
             myVolume.width = 8;
             myVolume.height = 8;

             myVolume.Display(); */


            /* //constructor type
             human myVolume = new human(7, 8, 8);

             myVolume.Display(); */


            /*
            //setters getters type -->these are methods
            human myVolume = new human();
            myVolume.SetLength(7);
            myVolume.SetHeight(8);
            myVolume.SetWidth(8);

            // return the variables
            Console.WriteLine("the length {0} and width  {1} and height {2}", myVolume.GetLength(), myVolume.GetWidth(), myVolume.GetHeight());

            myVolume.Display();
            */

            /*
            //proparties
            human myVolume = new human();
            myVolume.Height = 8;
            myVolume.Width = 8;
            myVolume.Length = 7;

            //return the variables using property
            Console.WriteLine("the length {0} and width  {1} and height {2}", myVolume.Length, myVolume.Width, myVolume.Height);

            myVolume.Display();
            */

            //proparties without member variable
            human myVolume = new human();
            myVolume.length = 7;
            myVolume.width = 8;
            myVolume.height = 8;

            Console.WriteLine("the length {0} and width  {1} and height {2} ", myVolume.length, myVolume.width, myVolume.height);

            myVolume.Display();


           /* human mySurface = new human();
            mySurface.Height = 7;
            mySurface.Length = 6;
            mySurface.Display();*/


        }
    }
}
