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
        public List<Department> departments { get; private set; }

        public string Location { get; private set; }

        //Constructors
        public Office(string location)
        {
            departments = new List<Department>();
            Department department = new Department("Notaris");
            departments.Add(department);
            Location = location;
        }

        public Office() { }

        //Methods
        public List<Department> GetAllDepartments()
        {
            return departments;
        }

        public string TryAddDepartment(string departmentName)
        {
            string departmentMayBeAdded = "Department may not be added";
            Department department = new Department(departmentName);
            if (DepartmentMayBeAdded(department))
            {
                departments.Add(department);
                departmentMayBeAdded = "Department has been added";
            }

            return departmentMayBeAdded;
        }

        private bool DepartmentMayBeAdded(Department newDepartment)
        {
            bool departmentMayBeAdded = true;
            foreach (var department in departments)
            {
                if (departments.Contains(newDepartment) == true)
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
