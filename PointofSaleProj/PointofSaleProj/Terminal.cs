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

        public List<Product> Reciept { get; set; } = new List<Product>();
        public Terminal()
        {
            Menu.Add(new Product("Coffee", "Drinks", "Just plain coffee", 1.99));
            Menu.Add(new Product("Tea", "Drinks", "Earl Grey", 0.99));
            Menu.Add(new Product("Espresso", "Drinks", "STRONG", 1.99));
            Menu.Add(new Product("Latte", "Drinks", "Mostly Milk", 2.99));
            Menu.Add(new Product("Bagel", "Food", "Not a doughnut", 3.00));
            Menu.Add(new Product("Breakfast sandwich", "Food", "Egg, Bacon, cheese", 4.50));
            Menu.Add(new Product("Breakfast burrito", "Food", "With Salsa", 4.50));
            Menu.Add(new Product("Lemon Bar", "Food", "Dessert for Breakfast", 3.99));
            Menu.Add(new Product("Croissant", "Food", "French", 2.50));
            Menu.Add(new Product("Muffin", "Food", "Changes Daily", 2.99));
            Menu.Add(new Product("Hat", "Merch", "Fitted", 5.00));
            Menu.Add(new Product("Shirt", "Merch", "Only size XXXL available", 6));

        }

        public static void BuildReceipt(List<Product> products)
        {
            List<Order> orders = new List<Order>();
            bool exit = false;
            while (!exit)
            {
                // Display menu
                Console.WriteLine("Welcome to the Product Ordering System!");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Available Products:");
                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {products[i].Name} ({products[i].Category}): {products[i].Description} - ${products[i].Price}");
                }
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("What would you like to order? (Enter a number from 1 to 12)");
                int productIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                // Ask for quantity
                Console.WriteLine("How many would you like to order?");
                int quantity = Convert.ToInt32(Console.ReadLine());

                // Calculate line total
                double lineTotal = products[productIndex].Price * quantity;

                // Add order to list
                Order order = new Order(products[productIndex], quantity, lineTotal);
                orders.Add(order);

                // Ask if user wants to order more or complete purchase
                Console.WriteLine("Would you like to order more or complete purchase? (Enter '1' to order more or '2' to complete purchase)");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        continue;
                    case 2:
                        exit = true;
                        break;
                }
            }

            // Display receipt
            Console.WriteLine("Order Receipt");
            Console.WriteLine("-------------------------------------");
            double total = 0;
            foreach (Order order in orders)
            {
                Console.WriteLine($"{order.Product.Name} ({order.Product.Category}): {order.Quantity} x ${order.Product.Price} = ${order.LineTotal}");
                total += order.LineTotal;
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Total: ${total}");
        }


        public void PrintMenu()
        {
            for(int i  = 0; i < Menu.Count; i++)
            {
                Product p = Menu[i];
                Console.WriteLine(i+1 + " - " + p.Name + " - " + p.Description + " - " + 
                    "$" + p.Price);
            }
        }
       

    }

   

}
