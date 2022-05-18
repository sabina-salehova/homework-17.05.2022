using System;
using System.Collections.Generic;
using System.Text;
using task.Models;

namespace task.Interfaces
{
    interface IOrderServices
    {
        public List<Order> Orders { get; }
        public void ShowCurrentProducts();
        public void ToOrder(List<Product> products, Order order);
        public void ShowAllOrders();
    }
}
