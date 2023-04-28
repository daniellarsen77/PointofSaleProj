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
        
    }

}
