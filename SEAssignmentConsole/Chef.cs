using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class Chef : Employee
    {

        public Chef(int id, string name, string nric, string gender, string Contactno, DateTime datejoin, string status) : base(id,name,nric,gender,Contactno,datejoin,status)
        { }

        public void selectOrder(Order order)
        {
            order.ordstatus = "Preparing";
            Console.WriteLine("Press enter when order is ready");
            Console.ReadLine();
            order.ordstatus = "Ready";
            //order.ordrdy = DateTime.Now;
            Console.ReadLine();
            Console.WriteLine("Order is Completed");
            Console.WriteLine("Exit?");
            Console.ReadLine();
        }

    }
}
