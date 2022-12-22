using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VakantiePlannerModules
{
    public class Employee
    {
        //Properties
        public List<Holiday> holidays { get; private set; }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public int VacationDays { get; private set; }

        //Constructors
        public Employee(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public Employee() { }

        //Methods
        public int GetVacationDays()
        {
            throw new System.NotImplementedException();
        }

        public List<Holiday> GetHolidays()
        {
            throw new System.NotImplementedException();
        }

        public Holiday PlanHoliday()
        {
            throw new System.NotImplementedException();
        }
    }
}
