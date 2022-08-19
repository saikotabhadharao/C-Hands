using System;

namespace enum1
{
    public static enum days
    {
        monday=1,tuesday=21,wednesday=35,thursday=65,friday=78
    }
    internal class Program
    {
        public static days meetingDate { get; set; } = (days)1;
        static void Main(string[] args)
        {
            days d = (days)1;
            Console.WriteLine(d);           // o/p: monday
            Console.WriteLine((int)d);      // o/p: 1
            foreach(string s in Enum.GetNames(typeof(days)))
            {
                Console.WriteLine(s);
            }
            foreach(int i in Enum.GetValues(typeof(days)))
            {
                Console.WriteLine(i+":"+(days)i);
            }
            Console.WriteLine(meetingDate);
            meetingDate = (days)35;
            Console.WriteLine(meetingDate);
        }
    }
}
