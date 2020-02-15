using System;

namespace SEAssignmentConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            
        }

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
        }
    }
}
