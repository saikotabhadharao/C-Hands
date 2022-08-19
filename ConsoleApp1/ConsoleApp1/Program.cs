using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
       // public delegate string checkAnagramDelegate(string w1, string w2);
        
        static void Main(string[] args)
        {
            //ANAGRAM CODE
            Console.WriteLine("Enter the first string");
            string w1 = Console.ReadLine();
            Console.WriteLine("Enter the second string");
            string w2 = Console.ReadLine();
            Program p = new Program();
            // checkAnagramDelegate check =new checkAnagramDelegate(p.checkAnagram);
            p.CheckAnagram(w1, w2);
        }
        public void CheckAnagram(string word1, string word2)
        {
            Console.WriteLine(word1);
            Console.WriteLine(word1[0]);
            Console.WriteLine(word1.Length);
            if(Char.IsLetter(word1[1]))
            {
                Console.WriteLine("true");
            }
            if(word1[1]==word2[1])
            {
                Console.WriteLine("true");
            }
           // string str = "kotasai,ande,mav";
            char[] ch = word1.ToCharArray();
            for(int i=0;i<ch.Length;i++)
            {
                Console.WriteLine(ch[i]);
            }
            Array.Sort(ch);
            for (int i = 0; i < ch.Length; i++)
            {
                Console.WriteLine(ch[i]);
            }
            //Console.ReadKey();

        }
    }
}
