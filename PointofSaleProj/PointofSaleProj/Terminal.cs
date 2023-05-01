using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointofSaleProj
{
    class Terminal
    {
        public List<Product> Menu { get; set; } = new List<Product>();

        public Dictionary<Product, int> Reciept { get; set; } = new Dictionary<Product, int>();
        public Terminal()
        {
            Menu.Add(new Product("Coffee", "Drinks", "Just plain coffee", 1.99, 0));
            Menu.Add(new Product("Tea", "Drinks", "Earl Grey", 0.99, 0));
            Menu.Add(new Product("Espresso", "Drinks", "STRONG", 1.99, 0));
            Menu.Add(new Product("Latte", "Drinks", "Mostly Milk", 2.99, 0));
            Menu.Add(new Product("Bagel", "Food", "Not a doughnut", 3.00, 0));
            Menu.Add(new Product("Breakfast sandwich", "Food", "Egg, Bacon, cheese", 4.50, 0));
            Menu.Add(new Product("Breakfast burrito", "Food", "With Salsa", 4.50, 0));
            Menu.Add(new Product("Lemon Bar", "Food", "Dessert for Breakfast", 3.99, 0));
            Menu.Add(new Product("Croissant", "Food", "French", 2.50, 0));
            Menu.Add(new Product("Muffin", "Food", "Changes Daily", 2.99, 0));
            Menu.Add(new Product("Hat", "Merch", "Fitted", 5.00, 0.06));
            Menu.Add(new Product("Shirt", "Merch", "Only size XXXL available", 6, 0.06));
        }
        public void PrintMenu()
        {
            for (int i = 0; i < Menu.Count; i++)
            {
                Product p = Menu[i];
                Console.WriteLine("{0} - {1} - {2} - {3:C}", i + 1, p.Name, p.Description, p.Price);
            }
        }

        public void BuildRecipt()
        {

            bool goOn = true;
            while (goOn)
            {
                int index = Validator.GetValidIntInput("Please select an item number to purchase:", 1, Menu.Count);

                int quantity = Validator.GetValidIntInput("Please enter a quantity:", 1, int.MaxValue);
                if (Reciept.ContainsKey(Menu[index - 1]))
                {
                    Reciept[Menu[index - 1]] += quantity;
                }
                else
                {
                    Reciept.Add(Menu[index - 1], quantity);
                }
                Console.WriteLine("Continue shopping? y/n");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    goOn = true;
                }
                else if (input == "n")
                {                   
                    PrintReceipt();
                    goOn = false;
                }
                else
                {
                    Console.WriteLine("I didn't understand that, would you like to continue shopping? y/n");
                    continue;
                }
            }            
        }
        public void PrintReceipt()
        {
            Console.WriteLine("Receipt:");
            Console.WriteLine("=====================");
            double subtotal = 0;
            double salesTax = 0;
            foreach (KeyValuePair<Product, int> kvp in Reciept)
            {
                Product p = kvp.Key;
                int quantity = kvp.Value;
                double itemTotal = p.Price * quantity;
                Console.WriteLine(p.Name + "\t\t" + String.Format("{0:C}", p.Price * kvp.Value));
                subtotal += itemTotal;
                salesTax += p.Price * p.SalesTax * quantity;
            }
            
            Console.WriteLine("=====================");
            Console.WriteLine("Subtotal:\t" + String.Format("{0:C}", subtotal));
            Console.WriteLine("Sales Tax:\t" + String.Format("{0:C}", salesTax));
            
        }

        

        public double GetTotal()
        {
            double total = 0;
            double salesTax = 0;
            foreach (KeyValuePair<Product, int> kvp in Reciept)
            {
                Product p = kvp.Key;
                int quantity = kvp.Value;
                salesTax += p.Price * p.SalesTax * quantity;
                total += (p.Price * quantity) + salesTax;
            }
            return total;
        }

    }

   

}
