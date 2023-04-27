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
            Console.WriteLine("Please insert cash (enter value):");
            amountPaid = Convert.ToDouble(Console.ReadLine());
            double change = 0;
            if (amountPaid > amountOwed)
            {
                change = (amountPaid - amountOwed);
                Console.WriteLine("Change Due: $" + change);
            }
            else if (amountPaid < amountOwed)
            {
                Console.WriteLine("Not enough cash!");
                amountOwed -= amountPaid;
                Console.WriteLine(amountOwed + " is still owed.");
                PayCash();
            }
            else
            {
                Console.WriteLine("Thank you for shopping at Virtual BREWdio!");
            }
        }
        public void PayCreditCard()
        {
            Console.WriteLine("Please enter your 16-digit credit card number:");
            string cardNum = Console.ReadLine(); 
            if (cardNum.Length != 16)
            {
                Console.WriteLine("Invalid Card Number entry.");
                PayCreditCard();
            }
            Console.WriteLine("Enter expiration month:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter expiration year:");
            int year = Convert.ToInt32(Console.ReadLine());
            expirationDate = new DateTime(year, month, 1);
            if(expirationDate < DateTime.Now)
            {
                Console.WriteLine("Payment method failed. This card is expired.");
                PayCreditCard();
            }
            Console.WriteLine("Enter 3-digit CVV");
            string CVV = Console.ReadLine();
            if(CVV.Length != 3)
            {
                Console.WriteLine("Invalid CVV.");
                PayCreditCard();
            }
            Console.WriteLine("Thank you for shopping at Virtual BREWdio!");
        }
        public void PayCheck()
        {
            Console.WriteLine("Please enter check number:");
            string checkNum = Console.ReadLine();
            if (checkNum.Length != 9)
            {
                Console.WriteLine("Invalid check...or something, I don't fully understand how checks work");
                Console.WriteLine("Try again!");
                PayCheck();
            }
            else
            {
                Console.WriteLine("Thank you for shopping at Virtual BREWdio!");
            }
        }

    }
}
