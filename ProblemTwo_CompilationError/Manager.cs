﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class Manager : Emplyoee
    {
        public List<Employee> DirectReports { get; set; }
        public string CostCode { get; set; }

        public Manager(int eID,string eName,int eLevel,DateTime eDoJ, List<Employee> drEmployeesLst,string cCode)
        {
            this.EmpID = eID;
            this.EmpName = eName;
            this.EmpLevel = eLevel;
            this.DateOfJoining = eDoJ;
            DirectReports = drEmployeeLst;
            CostCode = CCode;
        }
        

        public List<string> GetMyReports()
        {
            return DirectReports.Select(x => x.EmpName).ToList();
        }

    }
 
}
