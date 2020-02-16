using System;
using System.Collections.Generic;

namespace SEAssignmentConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Food CheeseBurger = new Food(1, "Cheese Burger", "Cheese with Burger", 10.50, 100, "Available");
            Food Pasta = new Food(2, "Aglio Olio", "Garlic Speghetti", 20.10, 100, "Available");
            Food Nuggets = new Food(3, "Nuggets", "Fried Chicken Meat", 5.50, 100, "Available");

            var foodmenu = new List<Food> { CheeseBurger, Pasta, Nuggets };

            List<Food> Foodlist = new List<Food>()
            {
                CheeseBurger,Pasta,Nuggets
            };

            int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(1000, 2000);
            }


            Menu FoodMenu = new Menu(1, 3, Foodlist);

            Customer John = new Customer(1, "John", "NewYork, Singapore:", "johntan@gmail.com", "98765432");
            Customer Mary = new Customer(1, "Mary", "NewYork, Singapore:", "marytan@gmail.com", "98765432");
            Customer Dandy = new Customer(1, "Dandy", "NewYork, Singapore:", "dandytan@gmail.com", "98765432");
            CreditCard creditcard1 = new CreditCard("1234567891234567");
            CreditCard creditcard2 = new CreditCard("9874563219874563");
            BankAccount bankacc1 = new BankAccount("123456");
            BankAccount bankacc2 = new BankAccount("654321");


            Console.WriteLine("Welcome to HungryEatNow!");
            Console.WriteLine("Please Choose your role ");
            Console.WriteLine("1. Customer");
            Console.WriteLine("2. Employee");
            Console.Write("Enter the Number of your Role :");
            var role = Console.ReadLine();

            double deliverycharge = 0.00;
            List<Food> orderlist = new List<Food>();
            List<Order> orders = new List<Order>();
            double total = 0.00;
            var qty = "";
            var food = "";

            // Customer Role 
            if (role == "1")
            {
                while (true)
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.Write("Welcome Customer! Please Enter Your Name (with First Letter as Capital): ");
                    var custname = Console.ReadLine();
                    if (custname == John.name|| custname == Mary.name || custname == Dandy.name)
                    {
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("Welcome " + custname + "! What would you like to do?");
                        Console.WriteLine("1. Create New Order ");
                        Console.WriteLine("2. View Current/Past Orders");
                        Console.Write("Enter your option: ");
                        var customeroption = Console.ReadLine();

                        if(customeroption == "1")
                        {
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine("Outlets");
                            Console.WriteLine("---------");
                            Console.WriteLine("Changi");
                            Console.WriteLine("Clementi");
                            Console.WriteLine("Jurong");
                            Console.WriteLine("");
                            Console.Write("Please enter your outlet of choice :");
                            var outlet = Console.ReadLine();
                            while(true)
                            { 
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("Food Categories");
                                Console.WriteLine("---------");
                                Console.WriteLine("Mains");
                                Console.WriteLine("Sides");
                                Console.WriteLine("");
                                Console.Write("Please enter your Category of choice :");
                                var category = Console.ReadLine();
                                if (category =="Mains")
                                {
                                    Console.WriteLine("----------------------------------------------");
                                    Console.WriteLine("Food Menu");
                                    Console.WriteLine("---------");
                                    Console.Write(CheeseBurger.fdname + " ");
                                    Console.Write("$"+CheeseBurger.fdprice);
                                    Console.WriteLine("");
                                    Console.Write (Pasta.fdname +" ");
                                    Console.Write("$" + Pasta.fdprice);
                                    Console.WriteLine("");
                                    Console.Write("Please enter your Food of choice :");
                                    food = Console.ReadLine();

                                    Console.Write("Quantity : ");
                                    qty = Console.ReadLine();
                                    var foodqty = Int16.Parse(qty);
                                    if (food == CheeseBurger.fdname)
                                    {
                                        orderlist.Add(CheeseBurger);

                                    }

                                    if (food == Pasta.fdname)
                                    {
                                        orderlist.Add(Pasta);
                                    }


                                    Console.Write("Would your like to order more? yes/no : ");
                                    var ordermore = Console.ReadLine();

                                    total = orderlist[0].fdprice * foodqty;
                                    if (ordermore == "no")
                                    { break; }
                                    if (ordermore == "yes")
                                    { Console.WriteLine("Sorry, we do not support more than one type of product at a time!"); break; }


                                }

                                else if (category == "Sides")
                                {
                                    Console.WriteLine("----------------------------------------------");
                                    Console.WriteLine("Food Menu");
                                    Console.WriteLine("---------");
                                    Console.Write(Nuggets.fdname + " ");
                                    Console.Write(Nuggets.fdprice);
                                    Console.WriteLine("");
                                    Console.Write("Please enter your Food of choice :");
                                    food = Console.ReadLine();
                                    Console.Write("Quantity : ");
                                    qty = Console.ReadLine();
                                    var foodqty = Int16.Parse(qty);
                                    orderlist.Add(Nuggets);
                                    Console.Write("Would your like to order more? yes/no : ");
                                    var ordermore = Console.ReadLine();
                                    total = orderlist[0].fdprice * foodqty;
                                    if (ordermore == "no")
                                    { break; }
                                    if(ordermore == "yes")
                                    { Console.WriteLine("Sorry, we do not support more than one type of product at a time!"); break; }

                                }
                            }

                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine("Delivery Options");
                            Console.WriteLine("---------");
                            Console.WriteLine("Standard (+ $0)");
                            Console.WriteLine("Express (+ $6)");
                            Console.Write("Please enter your Delivery of choice :");
                            var deloption = Console.ReadLine();

                            Console.WriteLine("----------------------------------------------");
                            if (deloption == "Standard")
                            {
                                Console.WriteLine("You will receive your order in 3 hours");
                                deliverycharge = 0.00;
                            }
                            else
                            {
                                Console.WriteLine("You will receive your order in 15 minutes");
                                deliverycharge = 6.00;
                            }

                            

                            while (true)
                            {
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("Payment Options");
                                Console.WriteLine("---------");
                                Console.WriteLine("1.Credit Card");
                                Console.WriteLine("2.Bank Transfer");
                                Console.Write("Please enter your Payment of choice :");
                                var pymtoption = Console.ReadLine();
                                if (pymtoption == "1")
                                {
                                    Console.Write("Please Enter your Credit Card Number:");
                                    var ccnum = Console.ReadLine();
                                    if (ccnum == creditcard1.cardnumber)
                                    {
                                        Console.WriteLine("----------------------------------------------");
                                        Console.WriteLine("Payment Successful");
                                        total += deliverycharge;

                                        Order NewOrder = new Order();/*1, "Outlet: " + outlet + "Delivery Type: " + deloption, "submitted", DateTime.Now, orderlist, "", "", deliverycharge, total*/
                                        int amtOfOrders = orders.Count + 1;
                                        Console.WriteLine("----------------------------------------------");
                                        Console.WriteLine("Your Order Details");
                                        Console.WriteLine("Order Number:" + amtOfOrders);
                                        Console.WriteLine("Outlet: " + outlet);
                                        Console.WriteLine("Items: " + food);
                                        Console.WriteLine("Quantity: " + qty);
                                        Console.WriteLine("Delivery Charge: $" + deliverycharge);
                                        Console.WriteLine("Total Amount: $" + total);
                                        foreach(var items in food)
                                        NewOrder.Orderinfo = outlet;
                                        NewOrder.Ordernumber = amtOfOrders;
                                        NewOrder.Deliverycharge = deliverycharge;
                                        NewOrder.totalamt = total;
                                        NewOrder.ToString();
                                        orders.Add(NewOrder);
                                        Console.ReadLine();
                                        break;
                                    }
                                    else if (ccnum == creditcard2.cardnumber)
                                    {
                                         Console.WriteLine("----------------------------------------------");
                                        Console.WriteLine("Payment Failed");
                                    }
                                }
                                if (pymtoption == "2")
                                {
                                    Console.Write("Please Enter your Bank Account Number:");
                                    var banknum = Console.ReadLine();
                                    if (banknum == bankacc1.accountnumber)
                                    {
                                        Console.WriteLine("----------------------------------------------");
                                        Console.WriteLine("Payment Successful");
                                        total += deliverycharge;

                                        Order NewOrder = new Order();/*1, "Outlet: " + outlet + "Delivery Type: " + deloption, "submitted", DateTime.Now, orderlist, "", "", deliverycharge, total*/
                                        int amtOfOrders = orders.Count + 1;
                                        Console.WriteLine("----------------------------------------------");
                                        Console.WriteLine("Your Order Details");
                                        Console.WriteLine("Outlet: " + outlet);
                                        Console.WriteLine("Items: " + food);
                                        Console.WriteLine("Quantity: " + qty);
                                        Console.WriteLine("Delivery Charge: $" + deliverycharge);
                                        Console.WriteLine("Total Amount: " + total);
                                        foreach (var items in food)
                                        NewOrder.Orderinfo = outlet;
                                        NewOrder.Ordernumber = amtOfOrders;
                                        NewOrder.Deliverycharge = deliverycharge;
                                        NewOrder.totalamt = total;
                                        NewOrder.ToString();
                                        orders.Add(NewOrder);
                                        Console.ReadLine();
                                        break;
                                    }
                                    else if (banknum == bankacc2.accountnumber)
                                    {
                                        Console.WriteLine("----------------------------------------------");
                                        Console.WriteLine("Payment Failed");
                                    }

                                   

                                }
                                break;
                                
                            }

                  









                        }

                        else if(customeroption == "2")
                        {
                            foreach (var items in orders)
                            {
                                Console.WriteLine(items);
                                Console.WriteLine("----------------------");
                             
                            }
                            //Console.WriteLine(orders);
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input please try again");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry You are not a Member!");
                        
                    }
                }
            }

            if (role == "2")
            {

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
