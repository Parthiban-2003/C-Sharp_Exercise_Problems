using System;

namespace Pro
{
    public class Program
    {
        static string mymethod1(string key1)
        {
            return $"The Password '{key1}' is a very weak password.";
        }
        
        static string mymethod2(string key2)
        {
            return $"The Password '{key2}' is a weak password.";
        }
        
        static string mymethod3(string key3)
        {
            return $"The Password '{key3}' is a strong password.";
        }
        
        static string mymethod4(string key4)
        {
            return $"The Password '{key4}' is a very strong password.";
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            
            if (password == "1234")
            {
                Console.WriteLine(mymethod1(password));
            }
            else if (password == "abcdef")
            {
                Console.WriteLine(mymethod2(password));
            }
            else if (password == "abc123xyz")
            {
                Console.WriteLine(mymethod3(password));
            }
            else
            {
                Console.WriteLine(mymethod4(password));
            }
        }
    }
}
