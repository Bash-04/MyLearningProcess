using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsAppTeam
{
    // private string name;
    // public string Name{
    //  get { return name; }
    //  set { name = value; }
    // }

    public class Coach
    {
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Coach(string name, double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public void SignContract(double salary)
        {
            if (salary < 0)
            {
                throw new Exception("Dacht het niet!");
            }
            Salary = salary;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
