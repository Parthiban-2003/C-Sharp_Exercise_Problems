using System;

namespace midlab
{
    class labs
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter a noun?");
            string noun=Console.ReadLine();
            
            Console.WriteLine("Enter a verb");
            string verb=Console.ReadLine();
            
            Console.WriteLine("Enter an adjective");
            string adjective=Console.ReadLine();
            
            Console.WriteLine("Enter an adverb");
            string adverb=Console.ReadLine();
            
            Console.WriteLine($"Do You walk Your {adjective} {noun} {adverb}? That's hilarious!");
             
            
        }
    }
}
