using System;

namespace Problem
{
    public class Paint
    {
         private const int value=350;
         
        public static void Main(string[]args)
        {
           Console.WriteLine("Enter their Width?");
           int width=Convert.ToInt32(Console.ReadLine());
           
           Console.WriteLine("Enter their length?");
           int length=Convert.ToInt32(Console.ReadLine());
           
           int result=width*length;
           Console.WriteLine(result);
           
           int vall=(result+value-1)/value;
           Console.WriteLine(vall);
            
            
        }
    }
}