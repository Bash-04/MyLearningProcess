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
        public List<Office> offices = new List<Office>();
        public List<Department> departments { get; private set; }

        public string Location { get; private set; }

        //Constructors
        public Office(string location)
        {
            departments = new List<Department>();
            Location = location;
        }

        public Office() { }

        //Methods
        public List<Office> GetAllOffices()
        {
            return offices;
        }

        public string TryAddOffice(string location)
        {
            string officeMayBeAdded = "Office may not be added";
            Office office = new Office(location);
            if (OfficeMayBeAdded(office))
            {
                offices.Add(office);
                officeMayBeAdded = "Office has been added";
            }

            return officeMayBeAdded;
        }

        private bool OfficeMayBeAdded(Office newOffice)
        {
            bool officeMayBeAdded = true;
            foreach (var office in offices)
            {
                if (offices.Contains(newOffice) == true)
                {
                    officeMayBeAdded = false;
                }
            }
            return officeMayBeAdded;
        }

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
            throw new System.NotImplementedException();
        }
    }
}
