using System;

namespace Program
{
    public class SimpleInterest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the principal:");
            int Principal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the rate of interest:");
            double Rateofinterest = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the number of years:");
            int Numberofyear = Convert.ToInt32(Console.ReadLine());

            double SI = Principal * (1 + (Rateofinterest / 100) * Numberofyear);

            Console.WriteLine($"After {Numberofyear} years at { Rateofinterest}, the investment will be worth ${SI}");
        }
    }
}
