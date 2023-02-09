using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VakantiePlannerModules
{
    public class Holiday
    {
        // Properties
        public int EmployeeId { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string Description { get; private set; }
        public TimeSpan Duration { get; private set; }

        // Constructors
        public Holiday(int employeeId, DateTime startDate, DateTime endDate, TimeSpan duration)
        {
            EmployeeId = employeeId;
            StartDate = startDate.ToUniversalTime();
            EndDate = endDate.ToUniversalTime();
            Duration = duration;
        }

        public Holiday(int employeeId, DateTime startDate, DateTime endDate, string description)
        {
            EmployeeId = employeeId;
            StartDate = startDate.ToUniversalTime();
            EndDate = endDate.ToUniversalTime();
            Description = description;
        }

        public Holiday(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate.ToUniversalTime();
            EndDate = endDate.ToUniversalTime();
            CalculateDuration(startDate, endDate).ToString();
        }

        // Methods
        public TimeSpan CalculateDuration(DateTime startDate, DateTime endDate)
        {
            Duration = endDate - startDate;
            return Duration;
        }
    }
}
