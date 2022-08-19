using System;

namespace interface1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            link l = new link();
            l.test();
            l.show();
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
        public void test()
        {
            Console.WriteLine("the test is related to both interfaces");
        }
        public void show()
        {
            Console.WriteLine("the show is related to both interfaces");
        }
    }
}
