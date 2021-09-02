using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class DirectReport
    {
        public Employee ReportsTo { get; set; }
        public string ProjectCode { get; set; }

        public DirectReport(Employee managerEmpObj,string pCode) 
        {
           this.EmpID = eID;
            this.EmpName = eName;
            this.EmpLevel = eLevel;
            this.DateOfJoining = eDoJ;
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
        }
 
    }
}
