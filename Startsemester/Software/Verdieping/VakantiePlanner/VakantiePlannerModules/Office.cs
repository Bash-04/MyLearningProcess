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

        // Constructors
        /// <summary>
        /// Giving all the information with the constructor to build the full office object
        /// </summary>
        /// <param name="location"></param>
        /// <param name="numberOfEmployees"></param>
        /// <param name="solicitor"></param>
        public Office(string location, int numberOfEmployees, string solicitor)
        {
            Location = location;
            NumberOfEmployees = numberOfEmployees;
            Solicitor = solicitor;
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

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Office() { }

        // Methods
        List<Office> offices = new List<Office>();
        public List<Office> GetAllOffices()
        {
            Office office = new Office("Alle", 0, "Notaris");
            offices.Add(office);
            office = new Office("Deurne", 0, "Notaris");
            offices.Add(office);
            office = new Office("Gemert", 0, "Notaris");
            offices.Add(office);
            office = new Office("Uden", 0, "Notaris");
            offices.Add(office);

            return offices;
        }

        public void AddEmployee()
        {

        }
    }
}
