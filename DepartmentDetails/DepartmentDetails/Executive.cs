using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentDetails
{
    public class Executive:Employee
    {
        public Boolean _isExecutive { get; set; }

        public Executive() {

            _isExecutive = true;
        }

    }
}
