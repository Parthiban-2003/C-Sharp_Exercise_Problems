using System;

namespace Program
{
    public class TempConvert
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter therir Char C or F:");
            string input=Console.ReadLine();
            
            if(input.ToUpper() == "C")
            {
                Console.WriteLine("Enter therir fahrenheit:");
                int fahrenheit =Convert.ToInt32(Console.ReadLine());
                
                double celsius = (fahrenheit - 32) * 5.0 / 9.0;
                
            Console.WriteLine(celsius);
            }
            else
            {
                 Console.WriteLine("Enter therir celsius:");
               double celsius =Convert.ToDouble(Console.ReadLine());
                
           double fahrenheit = celsius * 9.0 / 5.0 + 32;
            Console.WriteLine(fahrenheit);
            }
        }
    }
}