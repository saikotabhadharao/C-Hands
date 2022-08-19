using System;
using System.Collections;

namespace array_list
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentTable = new Hashtable();           //hashtable declaration


            //constructor type
            Student stud1 = new Student(1, "kota", 97);
            Student stud2 = new Student(2, "sai", 86);
            Student stud3 = new Student(3, "nagendra", 90);
            studentTable.Add(stud1.id, stud1);     //hash table needs object so we can pass the values to class
            studentTable.Add(stud2.id, stud2);
            studentTable.Add(stud3.id, stud3);
           /* foreach(DictionaryEntry entry in studentTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("student id {0}",temp.id);
                Console.WriteLine("student name {0}",temp.name);
                Console.WriteLine("student cgp{0}",temp.cgp);
            }*/




            foreach(Student value in studentTable.Values)
            {
                Console.WriteLine("student id {0}", value.id);
                Console.WriteLine("student name {0}",value.name);
                Console.WriteLine("student cgp {0}",value.cgp);
            }
        }
        
    }
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int cgp { get; set; }
        public Student(int id,string name,int cgp)
        {
            this.id = id;
            this.name = name;
            this.cgp = cgp;
        }

    }
}

