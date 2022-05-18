using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    class Order
    {
        public List<Product> Products;
        public double TotalPrice;
        public DateTime Date;           

        public Order(List<Product> products, DateTime date)
        {
            Products = products;
            Date = date;
        }

        public double Discount(List<Product> products)
        {
            foreach (Product item in products)
            {
                TotalPrice += item.Price*item.ProductCount;
            }
            if (TotalPrice > 200)
                TotalPrice -= 0.2 * TotalPrice;
            else if (TotalPrice >= 100)
                TotalPrice -= 0.1 * TotalPrice;

            return TotalPrice;
        }        
    }
}
