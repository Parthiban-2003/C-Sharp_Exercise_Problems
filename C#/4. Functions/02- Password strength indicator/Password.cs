using System;

namespace Pro
{
    public class Password
    {
        static void mymethod1(int key1)
        {
            Console.WriteLine($"The Password '{key1}' is a very weak password.");
        }
        
        static void mymethod2(string key2)
        {
            Console.WriteLine($"The Password '{key2}' is a weak password.");
        }
        
         static void mymethod3(string key3)
        {
            Console.WriteLine($"The Password '{key3}' is a strong password.");
        }
        
         static void mymethod4(string key4)
        {
            Console.WriteLine($"The Password '{key4}' is a very strong password.");
        }
        
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter their password:");
            string password=Console.ReadLine();
            
            if(password == "1234")
            {
                mymethod1(1234);
            }
            else if(password == "abcdef")
            {
                mymethod2("abcdef");
            }
            else if(password=="abc123xyz")
             {
                mymethod3("abc123xyz");
            }
            else
            {
                mymethod4("132htf@or");
            }
        }
    }
}