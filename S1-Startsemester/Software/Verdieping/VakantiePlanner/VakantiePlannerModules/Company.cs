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
        public List<Office> Offices { get; private set; }

        //Constructors
        public Company() 
        {
            Offices = new List<Office>();
        }

        //Methods
        public List<Office> GetAllOffices()
        {
            return Offices;
        }

        public string TryAddOffice(string location)
        {
            string officeMayBeAdded = "Office may not be added";
            Office office = new Office(location);
            if (OfficeMayBeAdded(office))
            {
                Offices.Add(office);
                officeMayBeAdded = "Office has been added";
            }

            return officeMayBeAdded;
        }

        private bool OfficeMayBeAdded(Office newOffice)
        {
            bool officeMayBeAdded = true;
            foreach (var office in Offices)
            {
                if (Offices.Contains(newOffice) == true)
                {
                    officeMayBeAdded = false;
                }
            }
            return officeMayBeAdded;
        }
    }
}
