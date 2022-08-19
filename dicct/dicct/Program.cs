using System;
using System.Collections.Generic;
using System.Collections;

namespace dicct
{
    internal class Program
    {
        static Dictionary<int, List<String>> memberInfo = new Dictionary<int, List<String>>() {
                                    { 1, new List<string>(){ "Tom","Harry"} },
                                    { 2,new List<string>(){ "Sam","Peter"} },
                                    { 3,new List<string>(){ "Kim","Robert"} } };
        static void Main(string[] args)
        {
            memberInfo[1].Add("kota");
            for(int i=0;i<memberInfo[1].Count;i++)
            {
                Console.WriteLine(memberInfo[1][i]);
            }


            List<string> gold = memberInfo[1];
            for (int i = 0; i < gold.Count; i++)
            {
                Console.WriteLine(gold[i]);
            }
            List<string> silver =new List<string>() { "kota", "sai", "ande" };
            for (int i = 0; i <silver.Count; i++)
            {
                Console.WriteLine(silver[i]);
            }
            ArrayList arr = new ArrayList()
            {
                "kota",2.4,8.9

            };
            for(int i=0;i<arr.Count;i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
