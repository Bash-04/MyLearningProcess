using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace VakantiePlannerModules
{
    public class Office
    {
        public string location { get; private set; }
        public int numberOfEmployees { get; private set; }
        public string Solicitor { get; private set; }

        public Office(string location)
        {
            this.location = location;
        }

        public void AddEmployee()
        {
            throw new System.NotImplementedException();
        }

        public void AddOffice(string location)
        {
            int i = 0;
            Office office = new Office(location);
            List<Office> offices = new List<Office>();
            offices.Add(office);
            while (i < offices.Count())
            {
                Console.WriteLine(offices[i].location);
            }
        }
    }
}
