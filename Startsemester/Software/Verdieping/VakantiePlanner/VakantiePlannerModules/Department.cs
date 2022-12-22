using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VakantiePlannerModules
{
    public class Department
    {
        //Properties
        public List<Employee> employees { get; private set; }
        public List<Holiday> holidays { get; private set; }

        public string Name { get; private set; }

        //Constructors
        public Department(string departmentName)
        {
            employees = new List<Employee>();
            Employee employee = new Employee("Alle", "alle@gvgn.nl");
            employees.Add(employee);
            Name = departmentName;
        }

        public Department() { }

        //Methods
        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public string TryAddEmployee(string name, string email)
        {
            string employeeMayBeAdded = "Employee may not be added";
            Employee employee = new Employee(name, email);
            if (EmployeeMayBeAdded(employee))
            {
                employees.Add(employee);
                employeeMayBeAdded = "Employee has been added";
            }

            return employeeMayBeAdded;
        }

        private bool EmployeeMayBeAdded(Employee newEmployee)
        {
            bool employeeMayBeAdded = true;
            foreach (var employee in employees)
            {
                if (employees.Contains(newEmployee) == true)
                {
                    employeeMayBeAdded = false;
                }
            }
            return employeeMayBeAdded;
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
