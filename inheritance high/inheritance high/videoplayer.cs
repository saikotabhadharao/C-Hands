using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace inheritance_high
{
    internal class videoplayer:msgpost
    {
        private bool isPlaying = false;
        private int curposition = 0;
        Timer timer;
        public string videoURL { get; set; }
        public int length { get; set; }
        public videoplayer(string tittle,string sendByUser,bool isPublic,string videoURl,int length)
        {
            this.id = count();
            this.tittle = tittle;
            this.sendByUser = sendByUser;
            this.isPublic = isPublic;
            this.videoURL = videoURl;
            this.length = length;
        }
        public void play()
        {
            if (!isPlaying)
            {
                Console.WriteLine("playing");
                isPlaying = true;
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }
        private void TimerCallback(Object o)
        {
            if(curposition<length)
            {
                curposition++;
                Console.WriteLine($"the position is {curposition}");
                GC.Collect();
            }
            else
            {
                stop();
            }
        }
        public void stop()
        {
            //isPlaying = false;
            Console.WriteLine($"stopped at {curposition}");
            curposition = 0;
            timer.Dispose();
        }
    }
}
