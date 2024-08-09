using System;

namespace Problem
{
    public class Multisalcal
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("What is the order Amount? ");
            int Amount=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What state do you Live in?");
            string State  = Console.ReadLine();
            
            if(State == "Wisconsin")
            {
                double Tax =0.50;
                double tax1=Tax+Amount;
                
                Console.WriteLine($"The Tax is ${tax1}.");
            }
            else if(State == "EauClaire")
            {
                double Tax1=0.50;
                double tax2=Tax1+Amount;
                
                Console.WriteLine($"The Tax is ${tax2}.");
            }
            
            else if(State == "Dunn")
            {
                double Tax2=10;
                double tax3=Tax2+Amount;
                
                Console.WriteLine($"The Tax is ${tax3}.");
            }
            
            else
            {
                Console.WriteLine($"The total is ${Amount}.");
            }
        }
    }
}