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

        public int Ordernumber
        {
            get { return OrderNumber; }
            set { OrderNumber = value; }
        }

        public string Orderinfo
        {
            get { return OrderInfo; }
            set { OrderInfo = value; }
        }

        public double Deliverycharge
        {
            get { return DeliveryCharge; }
            set { DeliveryCharge = value; }
        }

        public double totalamt
        {
            get { return TotalAmount; }
            set { TotalAmount = value; }
        }
        
        public List<Food> Orderitems
        {
            get { return OrderItems; }
            set { OrderItems = value; }
        }


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

        public override string ToString()
        {
            return "Order Details:" + '\n' + 
                "Order Number: " +OrderNumber + '\n' + 
                "Outlet: " + OrderInfo + '\n' + 
                /*OrderItems + '\n' + */
                "Delivery Charge: " + DeliveryCharge + '\n' +
                "Total Amount: $" + TotalAmount;
        }
    }
}
