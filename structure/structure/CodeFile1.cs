using System;
namespace structure
{
    public struct name
    {
        int i;
        public void display()
        {
            Console.WriteLine("displaying "+i);
        }
        public static void Main()
        {
            name n = new name();
            n.display();
        }
    }
  
}
