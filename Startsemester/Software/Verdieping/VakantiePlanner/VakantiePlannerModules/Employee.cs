using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VakantiePlannerModules
{
    public class Employee
    {
        //Properties
        public List<Holiday> Holidays { get; private set; }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public int VacationDays { get; private set; }

        //Constructors
        public Employee(string name, string email)
        {
            Holidays = new List<Holiday>();
            Name = name;
            Email = email;
        }

        public Employee() { }

        //Methods
        public int GetVacationDays()
        {
            throw new System.NotImplementedException();
        }

        public List<Holiday> GetHolidays()
        {
            return Holidays;
        }

        public string TryPlanHoliday(DateTime startDate, DateTime endDate, string description)
        {
            string holidayMayBeAdded = "Holiday may not be added";
            Holiday holiday = new Holiday(startDate, endDate, description);
            if (HolidayMayBeAdded(holiday))
            {
                Holidays.Add(holiday);
                holidayMayBeAdded = "Holiday has been added";
            }

            return holidayMayBeAdded;
        }

        private bool HolidayMayBeAdded(Holiday newHoliday)
        {
            bool holidayMayBeAdded = true;
            if (Holidays.Count != null)
            {
                foreach (var holiday in Holidays)
                {
                    if (Holidays.Contains(newHoliday) == true)
                    {
                        holidayMayBeAdded = false;
                    }
                }
            }
            return holidayMayBeAdded;
        }
    }
}
