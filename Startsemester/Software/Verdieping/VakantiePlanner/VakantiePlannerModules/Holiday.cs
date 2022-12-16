using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VakantiePlannerModules
{
    public class Holiday
    {
        // Properties
        public DateTime startDate { get; private set; }
        public DateTime endDate { get; private set; }
        public DateTime Description { get; private set; }
        public TimeSpan duration { get; private set; }

        // Constructors
        public Holiday()
        {

        }

        // Methods
        public TimeSpan CalculateDuration()
        {
            duration = startDate - endDate;
            return duration;
        }
    }
}
