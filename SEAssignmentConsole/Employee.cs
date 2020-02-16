using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignmentConsole
{
    class Employee
    {
        private int EmployeeId { get; set; }
        private string Employeename { get; set; }
        private string Nric { get; set; }
        private string gender { get; set; }
        private string ContactNo { get; set; }
        private DateTime DateJoin { get; set; }
        private string Status {get; set;}
        public string task;

        public Employee(int id, string name, string nric, string gender, string contactno, DateTime datejoin, string status)
        {
            this.EmployeeId = id;
            this.Employeename = name;
            this.Nric = nric;
            this.gender = gender;
            this.ContactNo = contactno;
            this.DateJoin = datejoin;
            this.Status = status;

        }
    }
}
