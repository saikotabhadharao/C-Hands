using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class animal:people
    {
        public animal(string name,int age) : base(name,age)
        {

        }
        public override void eat()
        {
            base.eat();
        }
        public override void hitting()
        {
            base.hitting();
        }
    }
}
