using System;
using System.Collections.Generic;

namespace SEAssignmentConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HungryEatNow!");
            Console.WriteLine("Please Choose your role ");
            Console.WriteLine("1. Customer");
            Console.WriteLine("2. Employee");
            Console.Write("Enter the Number of your Role :");
            var role = Console.ReadLine();
            

            Food CheeseBurger = new Food(1, "Cheese Burger", "Cheese with Burger", 10.50, 100, "Available" );
            Food Pasta = new Food(2, "Aglio Olio", "Garlic Speghetti", 20.10, 100, "Available");
            Food Nuggets = new Food(3, "Nuggets", "Fried Chicken Meat", 5.50, 100, "Available");

            var foodmenu = new List<Food> { CheeseBurger, Pasta, Nuggets };

            List<Food> Foodlist = new List<Food>()
            {
                CheeseBurger,Pasta,Nuggets
            };

            Menu FoodMenu = new Menu(1, 3, Foodlist);
            

            if(role == "1")
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Welcome Customer! What would you like to do?");
                Console.WriteLine("1. Create New Order ");
                Console.WriteLine("2. View Current/Past Orders");
                Console.ReadLine();
            }




        }
        /*
        
        static void chefSelect(Chef c )
        {
            while(true)
            {
                string Options = "Chef is selected!";
                foreach (Order order in .OrderList) //needs to add the order list cs
                {
                    if(order.status == "New")
                    {
                        Options += "Order No. " + order.orderNo + "/n";
                    }
                }
                Options += "Select order to prepare: ";
                Console.Write(Options);
                string orderNum = Console.ReadLine();
                c.selectOrder(.OrderList[int.Parse(orderNum) - 1]); //needs to add the order list cs
                Console.Write("Select another order?");
                string choose = Console.ReadLine();
                if (choose.ToUpper() == "NO")
                {
                    break;
                }
            }
        }*/
    }
}
