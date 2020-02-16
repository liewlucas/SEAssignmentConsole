using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class BankAccount : Payment
    {
        private static float amt;
        private static string type;
        private string AccountNumber;
        public string accountnumber
        {
            get { return AccountNumber; }
            set { AccountNumber = value; }
        }

        public BankAccount(string number): base(amt,type)
        {
            this.AccountNumber = number;
        }
    }
}
