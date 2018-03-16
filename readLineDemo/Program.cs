using System;

namespace readLineDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name!");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello my name is {name}");
        }
    }
}
