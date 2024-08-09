using System;

namespace Program
{

public class CompareNums
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 == num2 || num1 == num3 || num2 == num3)
        {
            Console.WriteLine("Numbers must be different. ");
            return;
        }

        int largest = num1;
        if (num2 > largest)
        {
            largest = num2;
        }

        if (num3 > largest)
         {
            largest = num3;
         }

        Console.WriteLine($"The largest number is {largest}.");
    }
  }
}
