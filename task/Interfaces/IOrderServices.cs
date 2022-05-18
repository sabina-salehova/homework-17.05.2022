﻿using System;
using System.Collections.Generic;
using System.Text;
using task.Models;

namespace task.Interfaces
{
    interface IOrderServices
    {
        public List<Product> CurrentProducts { get; }
        public List<Order> Orders { get; }
        public void ShowCurrentProducts();
        public void ToOrder();
        public void ShowAllOrders();


    }
}
