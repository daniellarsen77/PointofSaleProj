using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointofSaleProj
{
    class Order
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double LineTotal { get; set; }

        public Order(Product product, int quantity, double lineTotal)
        {
            Product = product;
            Quantity = quantity;
            LineTotal = lineTotal;
        }

        public override string ToString()
        {
            return $"{Product.Name} ({Product.Category}): {Product.Description} - {Quantity} x ${Product.Price} = ${LineTotal}";
        }
    }
}
