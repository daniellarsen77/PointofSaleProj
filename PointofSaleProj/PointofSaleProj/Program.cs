using System.Xml.Schema;

namespace PointofSaleProj
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Visual BREWdio!");
            Console.WriteLine();
            Terminal terminal = new Terminal();
            terminal.PrintMenu();
            terminal.BuildRecipt();
            double total = terminal.GetTotal();
            Console.WriteLine("Total: " + total.ToString("C2"));
            Console.WriteLine();
            bool goOn = true;
            while (goOn)
            {
                Console.WriteLine("Please choose a payment method:");
                Console.WriteLine("Cash" + "\t" + "Credit Card" + "\t" + "Check");

                string payment = Console.ReadLine().ToLower();
                PaymentMethod p = new PaymentMethod(total);
                if (payment == "cash")
                {
                    goOn = false;
                    p.PayCash();
                }
                else if (payment == "credit card" || payment == "card" || payment == "credit")
                {
                    goOn = false;
                    p.PayCreditCard();
                }
                else if(payment == "check")
                {
                    goOn = false;
                    p.PayCheck();
                }
                else
                {
                    Console.WriteLine("I didn't understand that, please try again");
                    goOn = true; 
                }
            }
        }
    }
}