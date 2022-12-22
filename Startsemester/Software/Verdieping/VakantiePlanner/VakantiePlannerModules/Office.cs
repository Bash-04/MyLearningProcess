using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VakantiePlannerModules
{
    public class Office
    {
        //Properties
        public List<Department> Departments { get; private set; }

        public string Location { get; private set; }

        //Constructors
        public Office(string location)
        {
            Departments = new List<Department>();
            Department department = new Department("Notaris");
            Departments.Add(department);
            Location = location;
        }

        public Office() { }

        //Methods
        public List<Department> GetAllDepartments()
        {
            return Departments;
        }

        public string TryAddDepartment(string departmentName)
        {
            string departmentMayBeAdded = "Department may not be added";
            Department department = new Department(departmentName);
            if (DepartmentMayBeAdded(department))
            {
                Departments.Add(department);
                departmentMayBeAdded = "Department has been added";
            }

            return departmentMayBeAdded;
        }

        private bool DepartmentMayBeAdded(Department newDepartment)
        {
            bool departmentMayBeAdded = true;
            foreach (var department in Departments)
            {
                if (Departments.Contains(newDepartment) == true)
                {
                    departmentMayBeAdded = false;
                }
            }
            return departmentMayBeAdded;
        }

        public int GetNrOfEmployees()
        {
            int nrOfEmployees = 0;

            return nrOfEmployees;
        }
    }
}
