using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    class Product
    {
        static uint _id;
        public static uint Id { get => _id; } 
        public string Name;
        public double Price;
        public int ProductCount;
        static Product()
        {
            _id = default(int);  
        }
        public Product(string name, double price, int productCount)
        {
            _id++;
            Name = name;
            Price = price;
            ProductCount = productCount;
        }

    }
}
