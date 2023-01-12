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
        public List<Employee> Employees { get; private set; }
        public List<Holiday> Holidays { get; private set; }

        public string Name { get; private set; }

        //Constructors
        public Department(string departmentName)
        {
            Employees = new List<Employee>();
            Employee employee = new Employee("Alle");
            Employees.Add(employee);
            Name = departmentName;
        }

        public Department() { }

        //Methods
        public List<Employee> GetAllEmployees()
        {
            return Employees;
        }

        public string TryAddEmployee(string name, string email)
        {
            string employeeMayBeAdded = "Employee may not be added";
            Employee employee = new Employee(name, email);
            if (EmployeeMayBeAdded(employee))
            {
                Employees.Add(employee);
                employeeMayBeAdded = "Employee has been added";
            }

            return employeeMayBeAdded;
        }

        public string TryAddEmployee(string name, string email, int vacationDays)
        {
            string employeeMayBeAdded = "Employee may not be added";
            Employee employee = new Employee(name, email, vacationDays);
            if (EmployeeMayBeAdded(employee))
            {
                Employees.Add(employee);
                employeeMayBeAdded = "Employee has been added";
            }

            return employeeMayBeAdded;
        }

        private bool EmployeeMayBeAdded(Employee newEmployee)
        {
            bool employeeMayBeAdded = true;
            foreach (var employee in Employees)
            {
                if (Employees.Contains(newEmployee) == true)
                {
                    employeeMayBeAdded = false;
                }
            }
            return employeeMayBeAdded;
        }

        public int GetNrOfEmployees()
        {
            int NrOfEmployees = -1;
            foreach (var employee in Employees)
            {
                NrOfEmployees++;
            }
            return NrOfEmployees;
        }
    }
}
