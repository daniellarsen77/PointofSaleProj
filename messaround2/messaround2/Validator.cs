using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messaround2
{
    public class Validator
    {
        public static int GetValidQuantity(string prompt)
        {
            int quantity;

            while (true)
            {
                Console.Write(prompt);

                if (int.TryParse(Console.ReadLine(), out quantity))
                {
                    if (quantity >= 1)
                    {
                        return quantity;
                    }
                }

                Console.WriteLine("Invalid input, please enter a positive integer greater than 0.");
            }
        }

        public static Product GetValidProduct(List<Product> products, string prompt)
        {
            while (true)
            {
                Console.WriteLine("Available products:");
                Console.WriteLine("-------------------");

                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {products[i].Name} ({products[i].Category}): {products[i].Description} - ${products[i].Price}");
                }

                Console.Write(prompt);

                int productIndex;

                if (int.TryParse(Console.ReadLine(), out productIndex))
                {
                    if (productIndex >= 1 && productIndex <= products.Count)
                    {
                        return products[productIndex - 1];
                    }
                }

                Console.WriteLine("Invalid input, please enter the number of the product you wish to order.");
            }
        }

        public static double CalculateLineTotal(Product product, int quantity)
        {
            return product.Price * quantity;
        }
    }
}
