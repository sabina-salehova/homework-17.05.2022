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

        public Order(DateTime date)
        {
            Products = new List < Product > ();
            Date = date;
        }
    }
}
