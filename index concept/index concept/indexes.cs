using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index_concept
{
    internal class indexes
    {
        //int empId;
        public double empSalary;
        string empName, empNum;
        
        public indexes(string empName,string empNum,double empSalary)
        {
           // this.empId = empId;
            this.empName = empName;
            this.empNum = empNum;
            this.empSalary = empSalary;
        }
        public int empId
        {
            get { return empId; }
            set { empId = value; }
        }

    }
}
