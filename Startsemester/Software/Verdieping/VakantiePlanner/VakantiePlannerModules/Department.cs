using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VakantiePlannerModules
{
    public class Department
    {
        public string Name { get; private set; }

        public List<Employee> employees { get; private set; }

        public List<Holiday> holidays { get; private set; }

        //Constructors
        public Department(string departmentName)
        {
            Name = departmentName;
        }
        public Department() { }

        public List<Employee> GetEmployees()
        {
            throw new System.NotImplementedException();
        }

        public Employee AddEmployee()
        {
            throw new System.NotImplementedException();
        }

        public string GetName()
        {
            throw new System.NotImplementedException();
        }

        public int GetNrOfEmployees()
        {
            throw new System.NotImplementedException();
        }
    }
}
