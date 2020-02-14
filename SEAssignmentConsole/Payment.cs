using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class Payment
    {
        private float amount;
        private string type;


        public Payment(float amt, string type)
        {
            this.amount = amt;
            this.type = type;
        }
    }
}
