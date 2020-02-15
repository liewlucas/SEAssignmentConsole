using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class Menu
    {
        private int menuID {get;set;}
        private int menusize { get; set; }
        private List<Food> Items { get; set; }

        public Menu (int menuid, int size, List<Food> items)
        {
            this.menuID = menuid;
            this.menusize = size;
            this.Items = items;

        }
    }
}
