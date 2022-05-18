using System;
using System.Collections.Generic;
using System.Text;
using task.Interfaces;
using task.Models;

namespace task.Services
{
    class OrderServices : IOrderServices
    {

        public List<Product> CurrentProducts => GetCurrentProducts();

        List<Order> _orders=new List<Order>();
        public List<Order> Orders => _orders;

        public void ShowAllOrders()
        {
           
        }

        public void ShowCurrentProducts()
        {
            
        }

        public void ToOrder()
        {
            
        }

        public List<Product> GetCurrentProducts()
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
