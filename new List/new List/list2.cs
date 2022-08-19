using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_List
{
    class Details
    {
        public string name { get; set; }
        public int age { get; set; }
        public string location { get; set; }
    }
    internal class list2
    {
        List<Details> details = new List<Details>
        {
            new Details{name="kota",age=20,location="hyderabad"},
            new Details{name="sai",age=18,location="bengalur"},
            new Details{name="nagendra",age=22,location="hyd" }
        };
       foreach(Details det in details)

    }
}
