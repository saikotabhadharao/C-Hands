using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_high
{
    internal class image:msgpost
    {
        //public string url { get; set; }
        public image(string tittle,string sendByUser,bool isPublic)
        {
            this.id = count();
            this.tittle = tittle;
            this.sendByUser = sendByUser;
            this.isPublic = isPublic;
            
        }
        public int calc()
        {
            return count();
        }
    }
}
