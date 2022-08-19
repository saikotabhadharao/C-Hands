using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class human
    {
        /* we can access the outchanges
        public int height;
        public int width;
        public int length;
        public int volume;


        public void Display()
        {
            Console.WriteLine("the length {0} and height {1} and width{2} then volume is {3}", length, height, width, volume = length * width * height);
        }
       */

        /* //we can not access the outchanges
         private int height;
         private int width;
         private int length;
         private int volume;*/

        /* //constructor -->method for assign the member variables
         public human(int length, int width, int height)
         {
             this.height = height;
             this.length = length;
             this.width = width;

         }

         public void Display()
         {
             Console.WriteLine("the length {0} and height {1} and width{2} then volume is {3}", length, height, width, volume = length * width * height);
         }
        */

        /*
        //setters and getters--> these are called methods which are used to assign and return values
       
        //assigning length to the member variable
        public void SetLength(int length)
        {
            this.length = length;
        }
        //return length
        public int GetLength()
        {
            return this.length;
        }

        public void SetHeight(int height)
        {
            this.height = height;
        }
        public int GetHeight()
        {
            return this.height;
        }

        public void SetWidth(int width)
        {
            this.width = width;
        }
        public int GetWidth()
        {
            return this.width;
        }

        public void Display()
        {
            Console.WriteLine("the length {0} and height {1} and width{2} then volume is {3}", length, height, width, volume = length * width * height);
        }
        */

        /*
        //proparties with member variable declaration
        public int Height           //in property first letter should be capital
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }
        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("the length {0} and height {1} and width{2} then volume is {3}", length, height, width, volume = length * width * height);
        }
        */


         //propety with out member variable

         public int height { get; set; }
         public int width { get; set; }
         public int length { get; set; }

         public int volume { get; set; }
         //private int volume;

         public void Display()
         {
             Console.WriteLine("the length {0} and height {1} and width{2} then volume is {3}", length, height, width, volume = length * width * height);
         }
        
       /* private int length;
        private int height;
        private int surface;
        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
            }
        }
        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        public int Surface
        {
            get
            {
                return 2*(this.height + this.length);
            }
        }

        public void Display()
        {
            Console.WriteLine("he height{0} and length {1} then surface is{2}", length, height, surface = 2*(length + height));
        }*/
        ~human()
        {
            Console.WriteLine("destruction ocurs");
            
        }


    }
}
