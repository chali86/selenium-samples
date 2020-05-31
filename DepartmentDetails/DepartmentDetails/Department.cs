using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentDetails
{
    public class Department
    {
        private int _departmentNo;
        private string _departmentName;

        

        public Department( int _departNo , string _departName){

            _departmentNo = _departNo;
            _departmentName = _departName;

        }


        public string GetDepartmentDetails() {

            return _departmentNo + " " + _departmentName;


        }


    }
}
