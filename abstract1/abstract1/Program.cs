using System;

namespace abstract1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle rec = new rectangle(3, 6);
            
            Console.WriteLine(rec.getArea());
            circle cir = new circle(3);
            
            Console.WriteLine(cir.getArea());
        }
    }
    abstract class commonParameter
    {
        /*public int height, width, radius;
        public const float pi = 3.14f;*/
        public double height { get; set; }
        public double width { get; set; }
        public double radius { get; set; }
        public const float pi = 3.14f;
       
        public abstract double getArea();
    }
    class rectangle:commonParameter
    {
        public rectangle(double width,double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double getArea()
        {
            return  width * height;
        }

    }
    class circle : commonParameter
    {
        public circle(double radius)
        {
            this.radius = radius;
        }
        public override double getArea()
        {
            return pi * radius * radius;
        }
    }

}
