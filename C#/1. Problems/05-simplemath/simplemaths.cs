using System;

namespace simple
{
    class simplemath
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("What is the first number");
          int num1=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What is the second number");
          int num2= Convert.ToInt32(Console.ReadLine());
          
          int add,sub,mul,div;
          
          add=num1+num2;
          sub=num1-num2;
          mul=num1*num2;
          div=num1/num2;
          
          Console.WriteLine($"{num1} + {num2}={add}");
           Console.WriteLine($"{num1} - {num2}={sub}");
           Console.WriteLine($"{num1} * {num2}={mul}");
           Console.WriteLine($"{num1} / {num2}={div}");
        }
    }
}