

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      Console.WriteLine("What is the length of the room in feet? ");
      int length=Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("What is the width of the room in feet? ");
      int width=Convert.ToInt32(Console.ReadLine());
      
      int squarefeet;
      double m;
      
      squarefeet=length*width;
      Console.WriteLine(squarefeet);
      
      m=squarefeet*0.09290304;
      Console.WriteLine(m);
      
      
      Console.WriteLine($"You entered dimensions of{length} feet by {width} feet.");
      Console.WriteLine($"The area is");
      Console.WriteLine($"{squarefeet} square feet");
      Console.WriteLine($"{m} square meters");
    }
}