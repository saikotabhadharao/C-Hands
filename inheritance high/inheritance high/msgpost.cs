using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_high
{
    internal class msgpost
    {
        private static int countIdPost;
        public int id { get; set; }
        public string tittle { get; set; }
        public string sendByUser { get; set; }
        public bool isPublic { get; set; }
        public string url { get; set; }

        public msgpost()
        {
            id = 0;
            tittle = "this is about the info";
            sendByUser = "kotasai";
            isPublic = true;
            url = "www.google.com";
        }
        public msgpost(string tittle,string sendByUser,bool isPublic,string url)
        {
            this.id = count();
            this.tittle = tittle;
            this.sendByUser = sendByUser;
            this.isPublic = isPublic;
            this.url = url;
        }
        protected  int count()
        {
            return ++countIdPost;
        }
        public override string ToString()
        {
            
            return String.Format("{0} - {1} - by {2}", this.id, this.tittle, this.sendByUser);
        }
    }
}
