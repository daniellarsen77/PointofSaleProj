namespace messaround2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of products
            List<Product> products = new List<Product>()
            {
                new Product("Apple", "Fruit", "A juicy red apple", 0.99),
                new Product("Orange", "Fruit", "A sweet orange", 1.29),
                new Product("Banana", "Fruit", "A ripe banana", 0.79),
                new Product("Lemon", "Fruit", "A sour lemon", 0.49),
                new Product("Mango", "Fruit", "A tropical mango", 1.99),
                new Product("Grapes", "Fruit", "A bunch of grapes", 2.49),
                new Product("Bread", "Bakery", "A loaf of bread", 2.99),
                new Product("Bagel", "Bakery", "A fresh bagel", 1.49),
                new Product("Croissant", "Bakery", "A buttery croissant", 1.99),
                new Product("Muffin", "Bakery", "A blueberry muffin", 1.79),
                new Product("Donut", "Bakery", "A glazed donut", 0.99),
                new Product("Cake", "Bakery", "A slice of cake", 3.99)
            };

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
        }
    }
}