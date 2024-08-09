using System;

namespace Program
{
    public class BMICal
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter their weight:");
            int weight=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter their height:");
            int height=Convert.ToInt32(Console.ReadLine());
            
            double bmi=(weight/(height * height)) * 703;
            
              if (bmi >= 18.5 && bmi <= 25)
            {
                Console.WriteLine("You are within the ideal weight range.");
            }
            else{
                Console.WriteLine(" You are overweight. You should see your doctor");
            }
        }
    }
}