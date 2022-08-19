using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexStatemnts_in_list
{
    internal class GenericType
    {
        public string name { get; set; }
        public int age { get; set; }
        public string location { get; set; }

        public GenericType(string name,int age,string location)
        {
            this.name = name;
            this.age = age;
            this.location = location;
        }
    }
}
