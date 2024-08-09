using System;

namespace Program
{
    public class Passwordvalidation
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("What is the password?");
            string Password=Console.ReadLine();
            
            if(Password=="12345")
            {
                Console.WriteLine("I don't know you.");
            }
            else
            {
                Console.WriteLine("Welcome!");
            }
        }
    }
}