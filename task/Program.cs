using System;
using task.Services;
using task.Models;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---   WELCOME TO SOLD APPLICATION   --- ");
            byte selection;
            do
            {
                Console.WriteLine("\n Please enter the appropriate number according to the following options: ");
                Console.WriteLine("1. ToSold");
                Console.WriteLine("2. Show All Orders");
                Console.WriteLine("0. Exit");
                selection = OrderMenuServices.CheckSelection(Console.ReadLine(),2) ;
                Console.Clear();

                switch (selection)
                {
                    case 1:
                        OrderMenuServices.ToOrderMenu();
                        break;
                    case 2:
                        OrderMenuServices.ShowAllOrdersMenu();
                        break;               
 
                }
            } while (selection != 0);
        }
    }
}
