using System;
using System.Collections;
using System.Collections.Generic;

namespace impotant_keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* //different oprations in string
            string msg = "my name is kotasai";
            //replace
            string rename = msg.Replace("kotasai", "ande kotasai");
            Console.WriteLine(rename);      // o/p: my name is ande kotsai

            //convert to upper case
            rename = msg.ToUpper();
            Console.WriteLine(rename);

            //contains -->true or False
            Console.WriteLine(msg.Contains("sai"));
            rename = msg.Substring(0, 5);
            Console.WriteLine(rename);

            //accepting the character from user
            char ch = Console.ReadLine()[0];
            Console.WriteLine(ch);

            //convert int/float/double to string
            int n = 3;
            string k = n.ToString();
            Console.WriteLine(k);
            float f = 3.14f;
            k = f.ToString();
            Console.WriteLine(k);

            //convert float to double explicitely
            double d = (double)f;
            Console.WriteLine(d);
            //convert int to float implicitely
            d = n;
            Console.WriteLine(d);

            //convert string to int
            //way-1
            /* string s = "7";
             int m = Convert.ToInt32(s);
             double p = Convert.ToDouble(s);
             decimal c = Convert.ToDecimal(s);*/

            //way-2 using Parsing
         /*   string s = "7";
            int m = Int32.Parse(s);
            double p = double.Parse(s);
            decimal c = decimal.Parse(s);

            //string-->find if it is number or string
            string name = "my mail id is andekotasai9848@gmail.com";
            for(int i=0;i<name.Length;i++)
            {
                 Char.IsLetter(name[i]);    //it is check whether it is letter or not
                 Char.IsDigit(name[i]);
                 Char.IsWhiteSpace(name[i]);
                 Char.IsLetterOrDigit(name[i]);
                 Char.IsSeparator(name[i]);
                 Char.IsLower(name[i]);
                 Char.IsUpper(name[i]);
                 Char.IsPunctuation(name[i]);
                 Char.IsSymbol(name[i]);
                 
                    
            }
            /*ArrayList list = new ArrayList() { "kota","sai", 3, 6 };
            //for(int i=0;i<list.Count;i++)
            foreach(Object o in list)
            {
                Console.WriteLine(o);
            }

            //list-->generic type
            List<string> small = new List<string>();
            small[0] = "kota";
            small[1] = "sai";*/

            //array declaration
            int[] arr = new int[] { 0, 2, 4, 6, 2 };

            int[] arr1 = new int[2];
            arr1[0] = 6;
            arr1[1] = 2;

            //arraylist declaration -->non generic(it holds multiple type of data)
            ArrayList list = new ArrayList();
            list.Add(6);
            list.Add("kota");
            list.Add(6.74);

            //array list declaration at compile time
            ArrayList comp = new ArrayList() { 6, "kota", 6.87 };
            //arraylist contain differnt type of data so we call these using object
            //foreach-- case
            foreach(Object o in list)
            {
                Console.WriteLine(o);
            }
            //for loop case
            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }

            //list in geneic type-->it onedatatype at one type
            //declaration way-1
            /* List<string> people = new List<string>() { "kota", "sai", "ande" };
             List<string> people1 = new List<string>();
             people1.Add("kota");
             people1.Add("sai");
             //way-2
             var peopleAge = new List<int>() { 3, 6, 3 };
             var peopleAge1 = new List<int>();
             peopleAge1.Add(3);
             peopleAge1.Add(6);
             peopleAge1.Add(3);

             for (int i = 0; i < peopleAge.Count; i++)
             {
                 Console.WriteLine(peopleAge1[i]);
             }*/

            int n = Convert.ToInt32(Console.ReadLine());
            int[][] jagged = new int[n][];
            for

        }
    }
}
