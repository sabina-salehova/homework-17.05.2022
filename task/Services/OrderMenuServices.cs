using System;
using System.Collections.Generic;
using System.Text;
using task.Models;

namespace task.Services
{
    class OrderMenuServices
    {
        public static OrderServices orderServices = new OrderServices();
        public static void ShowAllOrdersMenu()
        {
            orderServices.ShowAllOrders();

        }
        public static bool checkGeneralProductCount()
        {
            double generalCount = 0;
            foreach (Product item in orderServices.Products)
            {
                generalCount += item.ProductCount;
            }
            if (generalCount == 0)
                return false;
            else
                return true;

        }
        public static void ToOrderMenu()
        {

            if (!checkGeneralProductCount())
            {
                Console.WriteLine("The product is not available in stock");
                return;
            }
            

            bool result = false;

            Order order = new Order(DateTime.Today);
            do
            {
                Console.WriteLine("----------------------------------------\n");
                orderServices.ShowCurrentProducts();
                Console.Write("Please enter product id: ");
                int productId = GetPositiveIntegerNumber(checkString(Console.ReadLine().Trim()));
                Console.Write("Please enter product count: ");
                int count = GetPositiveIntegerNumber(checkString(Console.ReadLine()));
                Product soldProduct = toSold(productId, count);
                if (soldProduct != null)
                {
                    order.TotalPrice += soldProduct.Price*soldProduct.ProductCount;
                    order.Products.Add(soldProduct);                   
                }
                Console.Write("To add products to the order, please enter \"yes\" or \"no\": ");
                result = GetBoolAnswer(checkString(Console.ReadLine()));
            } while (result);

            orderServices.ToOrder(order);
            Console.WriteLine("General price: " + order.TotalPrice);
            double discount = Discount(order.TotalPrice);
            Console.WriteLine("Discount: " + discount);
            double payment = order.TotalPrice - discount;
            order.TotalPrice = payment;
            Console.WriteLine("Payment: "+ payment);
            
        }
        public static double Discount(double totalPrice)
        {
            
            if (totalPrice > 200)
            {
                Console.WriteLine("Price was reduced by 20 percent.");
                return  (0.2 * totalPrice);
            }
            else if (totalPrice >= 100)
            {
                Console.WriteLine("Price was reduced by 10 percent.");
                return  (0.1 * totalPrice);
            }

            return 0;
        }
        public static int GetPositiveIntegerNumber(string str)
        {
            int number;
            while (!int.TryParse(str.Trim(), out number) || number <= 0)
            {
                Console.Write("Please enter correct positive integer number: ");
                str = Console.ReadLine();
            }

            return number;

        }

        public static string checkString(string str)
        {
            while (string.IsNullOrWhiteSpace(str) || string.IsNullOrEmpty(str))
            {
                Console.Write("Please enter value: ");
                str = Console.ReadLine();
            }

            return str;
        }

        public static Product toSold(int id, int count)
        {
            bool resultId = false;
            foreach (Product item in orderServices.Products)
            {
                if (id == item.Id)
                {
                    if (item.ProductCount == 0)
                    {
                        Console.WriteLine("This product is not available in stock.");
                        return null;
                    }
                    resultId = true;
                    if (item.ProductCount > 0 && item.ProductCount >= count)
                    {
                        Console.WriteLine("Product was added.");
                        item.ProductCount -= count;
                        Product pr = new Product(item.Name,item.Price,count);
                        return pr;
                    }
                }

            }
            if (resultId == false)
            {
                Console.WriteLine("There is no product with the entered id");
                return null;
            }
            Console.WriteLine("There are not enough products in stock.");
            return null;

        }

        public static bool GetBoolAnswer(string answer)
        {
            while (answer.ToLower().Trim() != "yes" && answer.ToLower().Trim() != "no")
            {
                Console.WriteLine("Please enter \"yes\" or \"no\": ");
                answer = Console.ReadLine();
            }

            if (answer.ToLower().Trim() == "yes")
                return true;
            else
                return false;
        }

        public static byte CheckSelection(string selection, byte number)
        {
            do
            {
                byte checkedNumber;
                if (byte.TryParse(selection.Trim(), out checkedNumber))
                {
                    for (byte i = 0; i <= number; i++)
                    {
                        if (checkedNumber == i)
                            return checkedNumber;
                    }
                }
                Console.Write("Please enter the correct selection: ");
                selection = Console.ReadLine();

            } while (true);
        }
    } 

}


