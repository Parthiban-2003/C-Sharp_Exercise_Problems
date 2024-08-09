using System;

namespace Proggram
{
    public class Legaldriving
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("What is Your Age?");
            int Age=Convert.ToInt32(Console.ReadLine());
            
            if(Age>=16)
            {
                Console.WriteLine("You are old enough to legally drive.");
            }
            else
            {
                Console.WriteLine("You are not old enough to legally drive.");
            }
        }
    }
}