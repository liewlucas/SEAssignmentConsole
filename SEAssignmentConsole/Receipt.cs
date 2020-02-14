using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class Receipt
    {
        private int ReceiptNo;
        private string PaymentDetails;
        private string PaymentType;
        private DateTime PaymentDate;

        public Receipt(int recpno, string pymntdetails, string pymntType, DateTime pymtDate)
        {
            this.ReceiptNo = recpno;
            this.PaymentDetails = pymntdetails;
            this.PaymentType = pymntType;
            this.PaymentDate = pymtDate;
        }
    }
}
