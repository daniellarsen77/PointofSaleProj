using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PointofSaleProj
{
    
    class PaymentMethod
    {
        public double amountPaid = 0;

        public DateTime expirationDate;
        public double amountOwed { get; set; }

        public PaymentMethod(double amountOwed)
        {
            this.amountOwed = amountOwed;
            amountOwed = 0;
        }
        public void PayCash() 
        {

            amountPaid = Validator.GetValidIntInput("Please insert cash. (enter value):", 0, 1000000);
            double change = 0;
            if (amountPaid > amountOwed)
            {
                change = Math.Round(amountPaid - amountOwed, 2);
                Console.WriteLine("Change Due: $" + change);
            }
            else if (amountPaid < amountOwed)
            {
                Console.WriteLine("Not enough cash!");
                amountOwed -= amountPaid;
                Console.WriteLine(Math.Round(amountOwed,2) + " is still owed.");
                PayCash();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for shopping at Virtual BREWdio!");
            }
        }
        public void PayCreditCard()
        {
            
            string cardNum = Validator.GetCardInfo("Please enter your 16-digit credit card number:", 16);
            
            
            DateTime expirationDate = Validator.CheckDate();
            
            string CVV = Validator.GetCardInfo("Enter 3-digit CVV", 3);
            Console.WriteLine();
            Console.WriteLine("Thank you for shopping at Virtual BREWdio!");
        }
        public void PayCheck()
        {

            string checkNUm = Validator.GetCardInfo("Please enter check number (9 digits):", 9);
            Console.WriteLine();
            Console.WriteLine("Thank you for shopping at Virtual BREWdio!");

        }

    }
}
