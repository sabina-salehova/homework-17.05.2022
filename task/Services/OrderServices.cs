using System;
using System.Collections.Generic;
using System.Text;
using task.Interfaces;
using task.Models;

namespace task.Services
{
    class OrderServices : IOrderServices
    {
        
        List<Order> _orders=new List<Order>();
        List<Product> _product = GetCurrentProducts();
        public List<Order> Orders => _orders;
        public List<Product> Products => _product;

        public void ShowAllOrders()
        {
            if (_orders.Count == 0)
            {
                Console.WriteLine("Not order yet.");
                return;
            }
            foreach (Order item in _orders)
            {
                Console.WriteLine("Total price: " + item.TotalPrice+", Date: "+item.Date.Date+"\n");
                foreach (Product pr in item.Products)
                {
                    Console.WriteLine(pr);
                }
                Console.Write("----------------------------------------------------");
            }

        }

        public void ShowCurrentProducts()
        {
            foreach (Product item in _product)
            {
                Console.WriteLine(item);
            }
        }

        public void ToOrder(Order order)
        {       
            _orders.Add(order);
        }

        public static List<Product> GetCurrentProducts()
        {
            List<Product> currentProducts = new List<Product>();
            Product milk = new Product("milk", 15,12);
            currentProducts.Add(milk);
            Product nutella200 = new Product("Nutella (200 gram)", 30, 10);
            currentProducts.Add(nutella200);
            Product bread = new Product("bread", 0.75, 30);
            currentProducts.Add(bread);
            return currentProducts;
        }
    }
}
