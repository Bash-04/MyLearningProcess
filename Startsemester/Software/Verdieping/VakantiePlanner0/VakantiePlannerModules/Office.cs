using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VakantiePlannerModules
{
    public class Office
    {
        // Properties
        public List<Employee> employees { get; private set; }

        public string Location { get; private set; }
        public int NumberOfEmployees { get; private set; }
        public string Solicitor { get; private set; }
        public string Solicitor2 { get; private set; }

        // Constructors
        /// <summary>
        /// Giving all the information with the constructor to build the full office object
        /// </summary>
        /// <param name="location"></param>
        /// <param name="numberOfEmployees"></param>
        /// <param name="solicitor"></param>
        /// <param name="solicitor2"></param>
        public Office(string location, int numberOfEmployees, string solicitor, string solicitor2)
        {
            Location = location;
            NumberOfEmployees = numberOfEmployees;
            Solicitor = solicitor;
            Solicitor2 = solicitor2;
        }

        /// <summary>
        /// Constructor to just give the location through
        /// </summary>
        /// <param name="location"></param>
        public Office(string location, string solicitor) 
        {
            Location = location;
            Solicitor = solicitor;
        }

        public Office() { }

        // Methods
        public void AddOffice()
        {
            throw new System.NotImplementedException();
        }

        List<Department> departments = new List<Department>();
        public List<Department> GetAllDepartments(Department savedDepartment)
        {
            Department department = new Department("Alle");
            departments.Add(department);
            departments.Add(savedDepartment);

            return departments;
        }

        public bool AddDepartment()
        {
            throw new System.NotImplementedException();
        }
    }
}
