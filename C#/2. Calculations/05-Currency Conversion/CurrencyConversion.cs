using System;

namespace Program
{
    public class CurrencyConversion
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("How many euros are you exchanging?");
            int amt1=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What is the exchange rate?");
            double amt2=Convert.ToDouble(Console.ReadLine());
            
            double Exchange=(amt1*amt2)/100;
            
            Console.WriteLine($"{amt1} euros at an exchange rate of {amt2} is {Exchange} U.S. dollars.");        
          
        }
    }
}
