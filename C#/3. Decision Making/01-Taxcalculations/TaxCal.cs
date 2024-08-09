using System;

namespace Program
{
    public class Taxcal
    {
        public static void Main(string[]args)
        {
            Console.WriteLine(" What is the order Amount?");
            int OrderAmount=Convert.ToInt32(Console.ReadLine().ToUpper());
            
            Console.WriteLine("What is the state?");
            string state=Console.ReadLine();
            
            if(state=="WI"|| state=="MN")
            {
                double dTax=0.55;
                
                double Total=OrderAmount+dTax;
                Console.WriteLine($"The subtotal is ${OrderAmount}.00.");
                Console.WriteLine($"The tax is ${dTax}.");
                Console.WriteLine($"The total is ${Total}.");
            }
        }
    }
}