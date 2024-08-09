using System;

namespace quotes
{
    class quotestext
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("What is the quote? ");
            string quotes=Console.ReadLine();
            
            Console.WriteLine("Who said it?");
            string author=Console.ReadLine();
            
            Console.WriteLine(author+" says \""+quotes+"\"");
            
        }
    }
}

