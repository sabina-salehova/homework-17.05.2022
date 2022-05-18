using System;
using System.Collections.Generic;
using System.Text;

namespace task.Services
{
    class OrderMenuServices
    {
        OrderServices orderServices = new OrderServices();
        public void ToOrderMenu()
        {
            orderServices.ShowAllOrders();

        }

        
    }
}
