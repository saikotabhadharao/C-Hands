using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class people
    {
        public string name { get; set; }
        public int age { get; set; }


        public people(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void eat()
        {
            Console.WriteLine("if he hungry then he eat");
        }
        public virtual void hitting()
        {
            Console.WriteLine("if he fear about any thing then he hit another person");
        }
    }
}
