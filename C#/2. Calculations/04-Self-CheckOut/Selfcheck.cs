using System;

namespace self
{
    public class SelfCheckOut
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter the price of item 1:");
            int item1=Convert.ToInt32(Console.ReadLine());
            
        Console.WriteLine("Enter the quantity of item 1");
         int qu1=Convert.ToInt32(Console.ReadLine());
         
          Console.WriteLine("Enter the price of item 2:");
            int item2=Convert.ToInt32(Console.ReadLine());
            
        Console.WriteLine("Enter the quantity of item 2");
         int qu2=Convert.ToInt32(Console.ReadLine());
         
         Console.WriteLine("Enter the price of item 3:");
            int item3=Convert.ToInt32(Console.ReadLine());
            
        Console.WriteLine("Enter the quantity of item 3");
         int qu3=Convert.ToInt32(Console.ReadLine());
         
         int val1=item1*qu1;
         int val2=item2*qu2;
         int val3=item3*qu3;
       int subtotal=(val1+val2+val3);
         
         Console.WriteLine($"Subtotal value is {subtotal}");
         
         Console.WriteLine("Tax amount is:");
       int tax=Convert.ToInt32(Console.ReadLine());
         
       int Totalamount=(subtotal+tax);
         Console.WriteLine($"Totalamount is: {Totalamount}");
        
        }
    }
}