using System;

namespace overloadingoverriding
{
    public class program
    {
        public static void Main(string[] args)
        {
            //object for child class
            child c = new child();  
            c.test();
            c.show();
            c.show(10);


            //object for parent class
            parent p = new parent();  
            p.test();

            //object for parent class instance of child class
            parent p1 = c;  //parent p1= new child;
            p1.show();


            
        }
    }
    class parent
    {
        public virtual void test()
        {
            Console.WriteLine("parent test method is exeuted");
        }
        public void show()
        {
            Console.WriteLine("parent show method is executed");
        }
    }
    class child:parent          //inherited
    {
        //overriding parents test method in child class
        public override void test()
        {
            Console.WriteLine("child test metod is executed");
        }
        //over loading parents show method in a child class
        public void show(int n)         //overload
        {
            Console.WriteLine("child show method is executed");
        }

    }
    
   
}