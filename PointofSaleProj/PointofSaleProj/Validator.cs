using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointofSaleProj
{
    using System;

    class Validator
    {
        public static int GetValidIntInput(string message, int min, int max)
        {
            while (true)
            {
                Console.Write(message);

                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input < min || input > max)
                    {
                        Console.WriteLine($"Please enter a number between {min} and {max}.");
                    }
                    else
                    {
                        return input;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
        public static string GetCardInfo(string message, int digits)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (input.Length != digits)
            {
                Console.WriteLine($"Must be {digits} long, please try again");
                return GetCardInfo(message, digits);
            }
            else 
            {
                return input.Trim();
            }
        }
        public static DateTime CheckDate()
        {
            
            int month = Validator.GetValidIntInput("Enter expiration month (MM):", 1, 12);

            int year = Validator.GetValidIntInput("Enter expiration year (YYYY):", 1, 9999);

            DateTime expirationDate = new DateTime(year, month, 1);
            if (expirationDate < DateTime.Now)
            {
                Console.WriteLine("Payment method failed. This card is expired.");
                Console.WriteLine("Please try again.");
                return CheckDate();
            }
            else
            {
                return expirationDate;
            }
        }
        
        
    }

}
