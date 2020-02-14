using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class Employee
    {
        private int EmployeeId;
        private string Employeename;
        private string nric;
        private string gender;
        private string contactNo;
        private DateTime DateJoin;
        private string Status;

        public Employee(int id, string name, string nric, string gender, string Contactno, DateTime datejoin, string status)
        {
            this.EmployeeId = id;
            this.Employeename = name;
            this.nric = nric;
            this.gender = gender;
            this.contactNo = Contactno;
            this.DateJoin = datejoin;
            this.Status = status;

        }
    }
}
