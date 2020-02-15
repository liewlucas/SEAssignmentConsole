using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class Manager : Employee
    {
        private DateTime startDate;

        public Manager (DateTime StartDate): base(Id, name, nric, gender, Contactno, datejoin, status)
        {
            this.startDate = startDate;

        }

    }
}
