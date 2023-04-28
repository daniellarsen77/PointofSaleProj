﻿using System;
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
        public void PrintMenu()
        {
            for(int i  = 0; i < Menu.Count; i++)
            {
                Product p = Menu[i];
                Console.WriteLine(i+1 + " - " + p.Name + " - " + p.Description + " - " + 
                    "$" + p.Price);
            }
        }
        public void BuildRecipt()
        {

            bool goOn = true;
            while (goOn)
            {
                Console.WriteLine("Please select an item number to purchase:");
                int index = Convert.ToInt32(Console.ReadLine()); //needs to validate for integers
                Reciept.Add(Menu[index-1]);
                Console.WriteLine("Continue shopping? y/n");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    goOn = true;
                }
                else if (input == "n")
                {                   
                    PrintReciept();
                    goOn = false;
                }
                else
                {
                    Console.WriteLine("I didn't understand that, would you like to continue shopping? y/n");
                    continue;
                }
            }
            
        }
        public void PrintReciept()
        {
            Console.WriteLine("Receipt:");
            Console.WriteLine("=================");
            for (int i = 0; i < Reciept.Count; i++)
            {
                Product p = Reciept[i];
                Console.WriteLine(p.Name + " - " +
                    "$" + p.Price);
            }
            Console.WriteLine("=================");
        }
        public double GetTotal()
        {
            double total = 0;
            for (int i = 0; i < Reciept.Count; i++)
            {
                Product p = Reciept[i];
                total += p.Price;
            }
            return total;
        }

    }

   

}
