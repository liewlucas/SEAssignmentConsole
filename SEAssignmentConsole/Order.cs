using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class Order
    {
        private int OrderNumber;
        private string OrderInfo;
        private string OrderStatus;
        private DateTime OrderCreated;
        private Food OrderItems;
        private DateTime OrderReady;
        private DateTime OrderDelivery;
        private double DeliveryCharge;
        private double TotalAmount;

        public Order(int ordnum, string ordinfo, string ordstatus, DateTime ordcreated, Food items,DateTime ordrdy, DateTime orddel, double delcharge, double totalamt)
        {
            this.OrderNumber = ordnum;
            this.OrderInfo = ordinfo;
            this.OrderStatus = ordstatus;
            this.OrderCreated = ordcreated;
            this.OrderItems = items;
            this.OrderReady = ordrdy;
            this.OrderDelivery = orddel;
            this.DeliveryCharge = delcharge;
            this.TotalAmount = totalamt;
        }
    }
}
