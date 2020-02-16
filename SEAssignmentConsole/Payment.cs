using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class Payment
    {
        private float amount;
        public float Amount   // property
        {
            get { return amount; }
            set { amount = value; }
        }
        private string type;
        public string Type   // property
        {
            get { return type; }
            set { type = value; }
        }


        public Payment(float amt, string type)
        {
            this.amount = amt;
            this.type = type;
        }
    }
}
