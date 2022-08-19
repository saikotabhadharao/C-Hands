using System;

namespace datetand_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.Year);
            Console.WriteLine(date.DayOfYear);
            Console.WriteLine(date.Day);
            Console.WriteLine(date.DayOfWeek);
            string str = Console.ReadLine();
            DateTime day = DateTime.Parse(str);
            Console.WriteLine(day);
            DateTime now = DateTime.Today;
            TimeSpan time = now.Subtract(day);
            Console.WriteLine(time);
            int daysinmonth = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine(daysinmonth);
        }
    }
}
