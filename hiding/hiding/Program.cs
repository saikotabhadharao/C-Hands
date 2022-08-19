using System;

namespace hiding
{
    internal class Program
    {
        public void Main(string[] args)
        {
            child c = new child();
            c.test1();
            c.show();
           
            
        }
    }
    class parent:object
    {
        //hiding
        public void test1()
        {
            Console.WriteLine("parent class test1 method executed");
        }

        //overriding
        public virtual void show()
        {
            Console.WriteLine("parent class show method is executed");
        }
    }
    class child:parent
    {
        public new void test1()
        {
            Console.WriteLine("child class test1 method is executed");
        }
        public override void show()
        {
            Console.WriteLine("child class show method is executed");
        }


    }
}
