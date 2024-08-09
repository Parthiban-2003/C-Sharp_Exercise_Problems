using System;

namespace Problems
{
    public static class Pizza
    {
         static void Main (string[]args)
        {
            Console.WriteLine("How many people?");
            int val1=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("How many pizza do you have?");
          int val2= Convert.ToInt32(Console.ReadLine());
          
          Console.WriteLine($"{val1} people with {val2} pizzas");
          
          Console.WriteLine("Each Person have how many pieces");
          int val3=Convert.ToInt32(Console.ReadLine());
          
            int totalPieces = val1 * val2; 
            int piecesPerPerson = totalPieces / val1; 
            int remainingPieces = totalPieces % val1; 

            Console.WriteLine($"Each person gets {piecesPerPerson} pieces of pizza.");
            Console.WriteLine($"There are {remainingPieces} leftover pieces.");
        }
    }
}






