using System;

namespace inheritance_high
{
    internal class Program
    {
        static void Main(string[] args)
        {
            msgpost msg = new msgpost();
            msgpost msg1 = new msgpost("my info","kotasai",true, "www.google.com");
            msgpost msg2 = new msgpost("my info", "kotasai", true, "www.google.com");
            Console.WriteLine(msg.ToString());
            Console.WriteLine(msg1.ToString());
            Console.WriteLine(msg2.ToString());
            image img = new image("this is my info","sai",false);
            Console.WriteLine(img.ToString());
            Console.WriteLine(img.calc());
            Console.WriteLine(img.url);
            videoplayer video = new videoplayer("my info", "kotasai", true, "www.google.com",10);
            video.play();
        }
    }
}
