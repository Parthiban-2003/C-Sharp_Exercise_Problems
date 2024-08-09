using System;

namespace Program
{
    public class BloodAlc
    {
        public static void Main(string[]args)
        {
            
            Console.WriteLine("Total alcohol consumed in ounces:");
            int alcohol=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Body weight in pounds:");
            int weight=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Alcohol distribution ratio:");
            double ratio=Convert.ToDouble(Console.ReadLine());
            
             Console.WriteLine("Number of hours since the last drink:");
            int hours=Convert.ToInt32(Console.ReadLine());
            
           
            double BAC = ((alcohol * 5.14) / (weight * ratio)) - (0.015 * hours); 
            if(BAC < 0.08)
            {
               Console.WriteLine("It is not legal for you to drive");
               Console.WriteLine($"Your BAC is {BAC}");
            }
            else
            {
                Console.WriteLine("It is legal for you to drive");
            }
        }
    }
}