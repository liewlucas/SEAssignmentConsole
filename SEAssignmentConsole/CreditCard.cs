using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class CreditCard : Payment
    {
        private static float amt;
        private static string type;
        private string CardNumber;
        public string cardnumber
        {
            get { return CardNumber; }
            set { CardNumber = value; }
        }

        public CreditCard(string number): base(amt,type)
        {
            this.CardNumber = number;
        }
    }
}
