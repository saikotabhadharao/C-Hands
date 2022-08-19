using System;
using System.Collections.Generic;
namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "my name is kota";
           string name= msg.Replace("name", "sai");
            Console.WriteLine(name);
            /* Stack<int> stack = new Stack<int>();
             List<int> mylist = new List<int>() { 1, 5, 7, 9, 3 };
             Console.WriteLine(mylist.GetRange(0,3));
             foreach(int i in mylist)
             {
                 Console.Write(i+" ");
                 stack.Push(i);
             }
             Console.WriteLine("");
             foreach(int i in stack)
             {
                 Console.Write(i+" ");
             }
             Console.WriteLine();
             int n = stack.Pop();
             Console.WriteLine(n);
             Console.WriteLine(stack.Pop());
             Console.WriteLine(stack.Peek());*/
            Queue<Order> que = new Queue<Order>();
           foreach(Order o in morningBatch())
            {
                Console.WriteLine(o); 
                que.Enqueue(o);
            }
           foreach(Order o in eveningbatch())
            {
                Console.WriteLine(o);
                que.Enqueue(o);
            }
            Console.WriteLine(que.Count);
            while(que.Count>0)
            {
                Order current = que.Dequeue();
                current.processing();
            }
        }
        public static Order[] morningBatch()
        {
            Order[] names = new Order[]
            {
                new Order(1,3),
                new Order(2,5),
                new Order(3,7)
            };
            return names;
        }
        public static Order[] eveningbatch()
        {
            Order[] names = new Order[2];
            /*{
                new Order(5,7),
            new Order(2,7)
            };*/
            names[0] = new Order(5, 7);
            names[1] = new Order(2, 7);
            return names;
        }
        
        
    }
    class Order
    {
        public int id { get; set; }
        public int qty { get; set; }
        public Order(int id,int qty)
        {
            this.id = id;
            this.qty = qty;
        }
        public void processing()
        {
            Console.WriteLine($"the id of the order{id} {qty}");
        }
    }
}
