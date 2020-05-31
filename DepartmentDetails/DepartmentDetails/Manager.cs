using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentDetails
{
    class Manager:Employee
    {
        public Boolean _isManager { get; set; }

        public Manager() {

            _isManager = true;
        }
    }

   
}
