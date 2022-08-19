using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index_concept
{
    internal class employe
    {
        int empId;
       
        string name, num, location;
        double salary;
       public employe(int empId,double salary,string name,string num,string location)
        {
            this.empId = empId;
            this.salary = salary;
            this.name = name;
            this.num = num;
            this.location = location;
        }*
      
       public object this[int index]
        {
            get
            {
                if(index==0)
                {
                    return empId;
                }
                else if(index==1)
                {
                    return salary;
                }
                else if (index == 2)
                {
                    return name;
                }
                else if (index == 3)
                {
                    return num;
                }
                else if (index == 4)
                {
                    return location;
                }
                return null;
            }
            set
            {
                if (index == 0)
                    empId = (int)value;
                else if(index==1)
                {
                    salary = (double)value;
                }
                else if (index == 2)
                {
                    name = (string)value;
                }
                else if (index == 3)
                {
                    num = (string)value;
                }
                else if (index == 4)
                {
                    location = (string)value;
                }

            }
        }

        // we can assign with the name also
        public object this[string name]
        {
            get
            {
                if(name=="id")
                {
                    return empId;
                }
                else if(name=="salary")
                {
                    return salary;
                }
                return null;        //null is mandatory other wise it shows error
            }
            set
            {
                if(name=="id")
                {
                    empId = (int)value;
                }
                else if(name=="salary")
                {
                    salary = (double)value;
                }
            }
        }
       
    }
}
