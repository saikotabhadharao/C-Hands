
using System;

namespace abstract2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            child c = new child();
            //Parent p = new Parent();          we cannot call parent abstract class with instance of parent
            Parent p = c;
            p.Age = 18;
            p.Name = "kota";
            c.Age = 20;
            c.Name = "sai";
            c.Add(4, 5);
            c.Sub(5, 3);

            Console.WriteLine(c.Age);
            Console.WriteLine(c.Name);

            Console.WriteLine(p.Age);
            Console.WriteLine(p.Name);
        }
    }
    public abstract class Parent
    {
        private string name;
        private int age;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void Sub(int a,int b)
        {
            Console.WriteLine(a-b);
        }
        public abstract void mul(int a, int b);
        public abstract void div(int a, int b);
    }
    public class child : Parent
    {
        public override void mul(int a, int b)
        {
            Console.WriteLine("mul={0}",a*b);
        }
        public override void div(int a, int b)
        {
            Console.WriteLine("div={0}",a/b);
        }

    }
}
