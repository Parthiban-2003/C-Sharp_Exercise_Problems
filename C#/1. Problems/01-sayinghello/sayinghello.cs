using System;

public class SayingHello
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("What is your name");
        string Name=Console.ReadLine();
        
        Console.WriteLine($"Hello, {Name}, nice to meet you!");
    }
}