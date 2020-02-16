using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class Order : OrderSubject
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
        private List<CustomerObserver> observers;

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

        public Order()
        {
            List<CustomerObserver> observers = new List<CustomerObserver>();
        }

        public void notifyCustomer()
        {
            
            foreach(CustomerObserver o in observers)
            {
                o.update(OrderStatus);
            }
        }

        public void registerObserver(CustomerObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(CustomerObserver o)
        {
            observers.Remove(o);
        }

        public void statusChanged()
        {
            notifyCustomer();
        }
        public string ordstatus
        {
            get { return OrderStatus; }
            set { OrderStatus = value; }
        }
        public string ordrdy
        {
            get { return OrderReady; }
            set { OrderReady = value; }
        }
        public int ordnum
        {
            get { return OrderNumber; }
            set { OrderNumber = value; }
        }
        public static List<Order> OrderList = new List<Order>(); 

    }
}
