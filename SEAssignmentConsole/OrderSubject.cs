using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    interface OrderSubject
    {
        void registerObserver(CustomerObserver o);
        void removeObserver(CustomerObserver o);
    
        void notifyCustomer();

    }
}
