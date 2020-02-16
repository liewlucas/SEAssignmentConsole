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
        private List<Food> OrderItems;
        private string OrderReady;
        private string OrderDelivery;
        private double DeliveryCharge;
        private double TotalAmount;

        public Order(int ordnum, string ordinfo, string ordstatus, DateTime ordcreated, List<Food> items, string ordrdy, string orddel, double delcharge, double totalamt)
        {
            this.OrderNumber = ordnum;
            this.OrderInfo = ordinfo;
            this.OrderStatus = ordstatus;
            this.OrderCreated = ordcreated;
            this.OrderItems = items;
            this.OrderReady = ordrdy; 
            this.DeliveryCharge = delcharge;
            this.TotalAmount = totalamt;
        }

  
    }
}
