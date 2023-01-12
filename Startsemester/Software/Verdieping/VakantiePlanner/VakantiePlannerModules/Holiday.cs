using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace VakantiePlannerModules
{
    public class Holiday
    {
        //Properties
        public string Description { get; private set; }

        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public TimeSpan Duration { get; private set; }

        //Constructors
        public Holiday(DateTime startDate, DateTime endDate, string description)
        {
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Duration = GetDuration(startDate, endDate);
        }

        public Holiday() { }

        // Methods
        private TimeSpan GetDuration(DateTime startDate, DateTime endDate)
        {
            TimeSpan Duration = endDate - startDate;
            return Duration;
        }
    }
}
