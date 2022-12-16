using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace VakantiePlannerModules
{
    public class Employee
    {
        // Properties
        public string name { get; private set; }
        public string office { get; private set; }
        public string department { get; private set; }
        public int vacationDays { get; private set; }
        public Holiday holiday { get; private set; }

        //  Methods
        public void GetName()
        {
            throw new System.NotImplementedException();
        }

        public void GetOffice()
        {
            throw new System.NotImplementedException();
        }

        public void SetOffice()
        {
            throw new System.NotImplementedException();
        }

        public void SetDepartment()
        {
            throw new System.NotImplementedException();
        }

        public void GetDepartment()
        {
            throw new System.NotImplementedException();
        }

        public void GetHoliday()
        {
            throw new System.NotImplementedException();
        }

        public void SetHoliday()
        {
            throw new System.NotImplementedException();
        }
    }
}
