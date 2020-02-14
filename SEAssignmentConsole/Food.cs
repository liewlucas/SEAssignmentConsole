using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class Food
    {
        private int FoodID;
        private string FoodName;
        private string FoodDescription;
        private double FoodPrice;
        private int Quantity;
        private Boolean FoodStatus;

        public Food(int fid, string fdname, string fddesc, double fdprice, int qty, bool fdstatus)
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
