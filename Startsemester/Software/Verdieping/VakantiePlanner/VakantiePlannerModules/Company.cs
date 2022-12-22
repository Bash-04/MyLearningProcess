using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VakantiePlannerModules
{
    public class Company
    {
        //Properties
        public List<Office> offices { get; private set; }

        //Constructors
        public Company() 
        {
            offices = new List<Office>();
        }

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
    }
}
