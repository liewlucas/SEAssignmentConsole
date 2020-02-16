using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class Food
    {
        private int FoodID;
        private string FoodName;
        public string fdname   // property
        {
            get { return FoodName; }
            set { FoodName = value; }
        }
        private string FoodDescription;
        private double FoodPrice;
        public double fdprice   // property
        {
            get { return FoodPrice; }
            set { FoodPrice = value; }
        }
        private int Quantity;
        private string FoodStatus;

        public Food(int fid, string fdname, string fddesc, double fdprice, int qty, string fdstatus)
        {
            this.FoodID = fid;
            this.FoodName = fdname;
            this.FoodDescription = fddesc;
            this.FoodPrice = fdprice;
            this.Quantity = qty;
            this.FoodStatus = fdstatus;
        }
    }
}
