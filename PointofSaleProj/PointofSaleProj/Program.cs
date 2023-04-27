﻿namespace PointofSaleProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Daniel was here");
=======
            Terminal terminal = new Terminal();
            terminal.PrintMenu();

          //Build Reciept here


            // Calculate totals
            double subtotal = 0;
            foreach (Order order in orders)
            {
                subtotal += order.LineTotal;
            }
            double salesTax = Math.Round(subtotal * 0.06, 2);
            double grandTotal = Math.Round(subtotal + salesTax, 2);

            // Ask for payment type
            Console.WriteLine("What is your payment type? (Enter '1' for cash, '2' for credit, or '3' for check)");
            int paymentType = Convert.ToInt32(Console.ReadLine());

            switch (paymentType)
            {
                case 1: // Cash
                    Console.WriteLine("What is the amount tendered?");
                    double amountTendered = Convert.ToDouble(Console.ReadLine());

                    // Calculate change
                    double change = Math.Round(amountTendered - grandTotal, 2);

                    // Display receipt
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Receipt:");
                    foreach (Order order in orders)
                    {
                        Console.WriteLine($"{order.Product.Name} ({order.Product.Category}): {order.Quantity} x ${order.Product.Price} = ${order.LineTotal}");
                    }
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"Subtotal: ${subtotal}");
                    Console.WriteLine($"Sales Tax: ${salesTax}");
                    Console.WriteLine($"Grand Total: ${grandTotal}");
                    Console.WriteLine($"Payment Type: Cash");
                    Console.WriteLine($"Amount Tendered: ${amountTendered}");
                    Console.WriteLine($"Change: ${change}");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Thank you for your purchase!");
                    break;

                case 2: // Credit
                    Console.WriteLine("What is the credit card number?");
                    string cardNumber = Console.ReadLine();
                    Console.WriteLine("What is the expiration date? (MM/YY)");
                    string expiration = Console.ReadLine();
                    Console.WriteLine("What is the CVV?");
                    string cvv = Console.ReadLine();

                    // Display receipt
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Receipt:");
                    foreach (Order order in orders)
                    {
                        Console.WriteLine($"{order.Product.Name} ({order.Product.Category}): {order.Quantity} x ${order.Product.Price} = ${order.LineTotal}");
                    }
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"Subtotal: ${subtotal}");
                    Console.WriteLine($"Sales Tax: ${salesTax}");
                    Console.WriteLine($"Grand Total: ${grandTotal}");
                    Console.WriteLine($"Payment Type: Credit");
                    Console.WriteLine($"Card Number: {cardNumber}");
                    Console.WriteLine($"Expiration Date: {expiration}");
                    Console.WriteLine($"CVV: {cvv}");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Thank you for your purchase!");
                    break;

                case 3: // Check
                    Console.WriteLine("What is the check number?");
                    string checkNumber = Console.ReadLine();

                    // Display receipt
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Receipt:");
                    foreach (Order order in orders)
                    {
                        Console.WriteLine($"{order.Product.Name} ({order.Product.Category}): {order.Quantity} x ${order.Product.Price} = ${order.LineTotal}");
                    }
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"Subtotal: ${subtotal}");
                    Console.WriteLine($"Sales Tax: ${salesTax}");
                    Console.WriteLine($"Grand Total: ${grandTotal}");
                    Console.WriteLine($"Payment Type: Check");
                    Console.WriteLine($"Check Number: {checkNumber}");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Thank you for your purchase!");
                    break;

                default:
                    Console.WriteLine("Invalid payment type entered.");
                    break;
            }
>>>>>>> Stashed changes
        }
    }
}