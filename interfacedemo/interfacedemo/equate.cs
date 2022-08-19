using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedemo
{
    internal class equate:IEquatable<equate>
    {
        public int date { get; set; }
        public equate(int date)
        {
            this.date = date;
        }
        public bool Equals(equate other)
        {
            return this.date == other.date;
        }
    }
}
