using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VakantiePlannerModules
{
    public class Holiday
    {
        public string Description { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public TimeSpan GetDuration()
        {
            throw new System.NotImplementedException();
        }
    }
}
