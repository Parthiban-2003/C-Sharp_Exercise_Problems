using System;

namespace retirement
{
    class Calculator
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("What is your current age?");
            int currentage=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("At what age would you like to retire? ");
            int retireage=Convert.ToInt32(Console.ReadLine());
            
            int result;
            
            result=Math.Abs(currentage - retireage);
            Console.WriteLine(result);
            
             int year;
            Console.WriteLine("Enter their Current Year:");
           int Currentyear=Convert.ToInt32(Console.ReadLine());
           
            year=Currentyear + result;
            //Console.WriteLine(year);
            
            Console.WriteLine($"You have {result} years left until you can retire.");
            
            Console.WriteLine($"It's {Currentyear}, so you can retire in {year}.");
        }
    }
}