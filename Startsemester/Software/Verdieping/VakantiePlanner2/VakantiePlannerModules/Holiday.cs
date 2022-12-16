using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VakantiePlannerModules
{
    public class Holiday
    {
        public DateTime startDate { get; private set; }
        public DateTime endDate { get; private set; }
        public DateTime Description { get; private set; }

        public void CalculateDuration()
        {
            throw new System.NotImplementedException();
        }
    }
}
