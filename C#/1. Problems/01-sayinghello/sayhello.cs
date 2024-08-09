using System;

namespace Sayinghello
{
    class Program
    {
        static void MyMethod(string fname)
        {
            Console.WriteLine("Hello," + fname + ", Nice to meet you!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What is your name:");
            string name = Console.ReadLine();
            MyMethod(name);
        }
    }
}