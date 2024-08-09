using System;

class Program
{
    public static void Main(string[]args)
    {
        
        double principalAmount = 1500;
        double annualRate = 4.3 / 100; 
        int numberOfYears = 6;
        int numberOfCompoundsPerYear = 4;

       
        double amount = CalculateCompoundInterest(principalAmount, annualRate, numberOfYears, numberOfCompoundsPerYear);

        
        Console.WriteLine($"${principalAmount} invested at {annualRate * 100}% for {numberOfYears} years");
        Console.WriteLine($"compounded {numberOfCompoundsPerYear} times per year is ${amount.ToString("0.00")}.");
    }

    static double CalculateCompoundInterest(double principal, double rate, int years, int compoundsPerYear)
    {
        double baseAmount = 1 + rate / compoundsPerYear;
        int totalCompounds = years * compoundsPerYear;
        double amount = principal * Math.Pow(baseAmount, totalCompounds);
        return Math.Round(amount, 2); 
    }
}
