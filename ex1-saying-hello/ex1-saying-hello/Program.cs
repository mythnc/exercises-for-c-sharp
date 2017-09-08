using System;

namespace ex1_saying_hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            Console.Write("Hello, " + name + ", nice to meet you!");
            Console.ReadKey();
        }
    }
}
