using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class Menu
    {
        private int menuID;
        private int menusize;
        private Food Items;

        public Menu (int menuid, int size, Food items)
        {
            this.menuID = menuid;
            this.menusize = size;
            this.Items = items;

        }
    }
}
