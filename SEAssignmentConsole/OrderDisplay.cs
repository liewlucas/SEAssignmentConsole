using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class OrderDisplay : CustomerObserver
    {
        private OrderSubject Order;

        public OrderDisplay(OrderSubject o)
        {
            this.Order = o;
            Order.registerObserver(this);
        }

        public void update(string status)
        {
            status = "New";
        }
    }
}
