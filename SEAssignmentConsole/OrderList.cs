using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class OrderList
    {
        private string orderInfo;

        private Order order;
        private Customer cust;
    }


    public class Customer
    {
        private List<OrderList> oList;
    }

    public class Order
    {
        private List<OrderList> oList;                                          
    }
}
