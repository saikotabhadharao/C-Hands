using System;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            animal ani = new animal("monkey",50);
            ani.hitting();
            ani.eat();
            Console.WriteLine($"the name of the animal is{ani.name} an the age is {ani.age}");
            people pep = new people("sai", 25);
            pep.eat();
            Console.WriteLine($"the name of the animal is{pep.name} an the age is {pep.age}");

        }
    }
}
