using System;

namespace number
{
    class CountingNumber
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("What is the input string?");
            string Name=Console.ReadLine();
            
            int count=0;
            
            for(int i=0;i<Name.Length;i++)
            {
                count++;
            }
            Console.WriteLine($"{Name} has {count} characters.");
        }
    }
}
