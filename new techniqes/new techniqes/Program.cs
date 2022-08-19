using System;
using System.Text; 

namespace new_techniqes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "my name is ande kotasai";
            //we can split the entire string into small strings
            //that can be stored in array
            string[] name = str.Split(" ");         // split and store directly into string array
            foreach(string s in name)
            {
                Console.WriteLine(s);
            }

            // array declaration => string[] name= new string[5];
            //convert string to characters and stored in character array
            string name1 = "kotasai";
            char[] charArray = name1.ToCharArray();         //characters are stored in char array
            foreach(char c in charArray)
            {
                Console.WriteLine(c);
            }
            str = "kota";
            StringBuilder sb = new StringBuilder("sai");        //which is used to concatenate the strings
            sb.Append(str);
            Console.WriteLine(sb);

            string s1 = "";                 //which is used to add the string and every time it create new memory
            s1 += "kota";
            s1 += "sai";
            Console.WriteLine(s1);

        }
    }
}
