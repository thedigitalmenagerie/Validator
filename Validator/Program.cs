using System;
using System.Linq;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a pin of only digits, numbering 4-8 characters:");
            var userPinInput = Console.ReadLine();
            if (userPinInput.All(char.IsDigit) && userPinInput.Length >= 4 && userPinInput.Length <= 8)
            {
                var validPin = true;
                if (validPin == true)
                {
                    Console.WriteLine("Your pin is valid");
                }
            } 
            else
            {
                var validPin = false;
                if (validPin == false)
                {
                    Console.WriteLine("Your pin is not valid");
                }
            }

            Console.WriteLine("Please enter your phone number");
            var userEnteredPhone = Console.ReadLine();
            var digitsOnly = string.Join("", userEnteredPhone.Split('-', '(', ')', ' '));
            if (digitsOnly.Length != 10)
            {
                var validPhone = false;
                if (validPhone == false)
                {
                    Console.WriteLine("That is not a valid phone number");
                }
            }
            else if (digitsOnly.StartsWith("555"))
            {
                var validPhone = false;
                if (validPhone == false)
                {
                    Console.WriteLine("That is not a valid phone number");
                }
            }
            else if (digitsOnly.All(char.IsDigit))
            {
                var validPhone = true;
                if (validPhone == true)
                {
                    Console.WriteLine("That is a valid phone number");
                }
            }
            else
            {
                var validPhone = false;
                if (validPhone == false)
                {
                    Console.WriteLine("That is not a valid phone number");
                }
            }
        }

    }
}
