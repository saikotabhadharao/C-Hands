using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_List
{
    internal class generic
    {
       /* private string name;
        private int age;
        private string location;
        private long pin;*/
        public string name { get; set; }
        public int age { get; set; }
        public string location { get; set; }
        public long pin { get; set; }

        public generic(string name,int age,string location,long pin)
        {
            this.name = name;
            this.age = age;
            this.location = location;
            this.pin = pin;
        }
    }
}
