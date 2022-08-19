using System;

namespace multiDelegates
{
    public delegate void AreaDelegate(double width, double height);
    public delegate void PerimeterDelegate(double width, double height);
    internal class Program
    {
        static void Main(string[] args)
        {
            Delegate mul = new Delegate();
            AreaDelegate Area =mul.Area;
            Area +=mul.Perimeter;
            Area(5, 4);
        }
    }
    class Delegate
    {
        public void Area(double width,double height)
        {
            Console.WriteLine("area is "+(width * height));
        }
        public void Perimeter(double width,double height)
        {
            Console.WriteLine("perimeter "+ 2*(width*height));
        }
    }
}
