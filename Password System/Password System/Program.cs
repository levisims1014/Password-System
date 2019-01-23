using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Password_System
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Welcome to Lehoo.com!");
                Email();
                Password();
                run = Continue();
            }
        }
        public static void Email()
        {
            bool correct = true;
            while (correct == true)
            {
                List<string> Email = new List<string>();
                Console.WriteLine("Enter your email address");
                string email = Console.ReadLine();
                Email.Add(email);
                try
                {
                    if (Regex.IsMatch(email, @"^[A-z0-9]{3,}(@)[A-z0-9]{3,}(.+)[A-z0-9]{2,3}$"))
                    {
                        Console.WriteLine("Success!");
                        correct = false;
                    }
                    else
                    {
                        Console.WriteLine($"{email} is not correct try again.");
                        correct = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please try again!");
                }
            }
        }
        public static void Password()
        {
            List<string> Passwords = new List<string>();
            bool response = true;
            string secret;
            while (response == true)
            {
                Console.WriteLine("Please create a special password with at least one uppercase charcter.");
                secret = Console.ReadLine();

                if (Regex.IsMatch(secret, @"^[A-Z]+[0-9]+[A-z0-9]{3,}$"))
                {
                    Console.WriteLine("This is a valid password!");
                    response = true;
                }
                else
                {
                    Console.WriteLine("Password is valid");
                    Passwords.Add(secret);
                    response = false;
                }
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("Would you like to again?");
            string again = Console.ReadLine().ToLower();
            bool repeat = true;

            if (again == "y")
            {
                repeat = true;
            }
            else if (again == "n")
            {
                Console.WriteLine("Thank you for playing, Goodbye!");
                repeat = false;
            }
            else
            {
                Console.WriteLine("Invalid input! Please try again");
                repeat = Continue();
            }
            return repeat;
        }
    }
}
