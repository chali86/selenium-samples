using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DepartmentDetails
{
    public class Employee
    {
        public int _employeeID { get; set; }
        public string _employeeName { get; set; }

        public Department _employeeDepartment { get; set; }

        public string SayName()
        {
            return "My Name is" + _employeeName;
        }

        public string DoWork()
        {
            if (_employeeDepartment == null)
            {
                return _employeeName + " doesn't have a department";
            }
            return "I am doing work at" + _employeeDepartment.GetDepartmentDetails();
        }
    }
}
