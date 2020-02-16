using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class Employee
    {
        private int EmployeeId { get; set; }
        private string Employeename { get; set; }
        private string nric { get; set; }
        private string gender { get; set; }
        private string contactNo { get; set; }
        private DateTime DateJoin { get; set; }
        private string Status {get; set;}

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
