using System;

namespace interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            link l = new link();
            ITestInterface1 T1 = l;         //parent reference to the child class instance
            ITestInterface2 T2 = l;
            T1.test();
            T1.show();
            T2.test();
            T2.show();
        }
    }
    public interface ITestInterface1
    {
        void test();
        void show();

    }
    public interface ITestInterface2
    {
        void test();
        void show();
    }
    public class link:ITestInterface1,ITestInterface2
    {
        void ITestInterface1.test()
        {
            Console.WriteLine("this test method related to only ITestInterface1");
        }
        void ITestInterface2.test()
        {
            Console.WriteLine("this test method related to only ITestInterface2");
        }
        void ITestInterface1.show()
        {
            Console.WriteLine("this show method related to only ITestInterface1");
        }
        void ITestInterface2.show()
        {
            Console.WriteLine("this show method related to only ITestInterface2");
        }

    }
}
