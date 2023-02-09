using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VakantiePlannerModules;

namespace VakantiePlannerGUI
{
    public partial class VakantieOverzicht : Form
    {
        Company Company = new Company();
        public VakantieOverzicht(Company company)
        {
            InitializeComponent();
            Company = company;
        }

        private void VakantieOverzicht_Load(object sender, EventArgs e)
        {
            AddAllHolidaysToListBox();
            AddDepartmentToSelectedDepartmentLabel();
        }

        public void AddAllHolidaysToListBox()
        {
            if (Company.GetAllOffices()[0].GetAllDepartments()[0].GetNrOfEmployees() != 0)
            {
                foreach (var employee in Company.GetAllOffices()[0].GetAllDepartments()[0].GetAllEmployees())
                {
                    if (employee.GetHolidays() != null)
                    {
                        for (int i = 0; i < employee.GetHolidays().Count(); i++)
                        {
                            lbHolidayEmployee.Items.Add(employee.Name);
                            lbHolidayStartDate.Items.Add(employee.GetHolidays()[i].StartDate.ToString());
                            lbHolidayEndDate.Items.Add(employee.GetHolidays()[i].EndDate.ToString());
                            lbHolidayDescription.Items.Add(employee.GetHolidays()[i].Description);
                        }
                    }
                }
            }
        }

        public void AddDepartmentToSelectedDepartmentLabel()
        {
            lblSelectedDepartment.Text = Company.GetAllOffices()[0].GetAllDepartments()[0].Name;
        }
    }
}
