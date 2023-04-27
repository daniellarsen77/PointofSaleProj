using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointofSaleProj
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

        public Product(string Name, string Category, string Description, double Price)
        {
            this.Name = Name;  
            this.Category = Category;
            this.Description = Description;
            this.Price = Price;
        } 
    }
}
