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

namespace VakantiePlanner
{
    public partial class VakantiePlanner : Form
    {
        public VakantiePlanner()
        {
            InitializeComponent();
        }


        private void GetAllOffices()
        {
            Office office = new Office();
            List<Office> offices = office.GetAllOffices();
            for (int i = 0; i < offices.Count; i++)
            {
                cbOffice.Items.Add(offices[i].Location);
            }
        }

        private void GetAllDepartments()
        {
            Department department = new Department();
            List<Department> departments = department.GetAllDepartments();
            for (int i = 0; i < departments.Count; i++)
            {
                cbDepartment.Items.Add(departments[i].Name);
            }
        }

        private void VakantiePlanner_Load(object sender, EventArgs e)
        {
            GetAllOffices();
            GetAllDepartments();
        }

        private void Calender_DateChanged(object sender, DateRangeEventArgs e)
        {
            Console.WriteLine(Calender.SelectionRange);
        }

        private void btnNewOffice_Click(object sender, EventArgs e)
        {
            string location = tbOfficeName.Text;
            string solicitor = tbOfficeSolicitor.Text;

            Office office = new Office(location, solicitor);
            List<Office> offices = office.GetAllOffices();

            offices.Add(office); 
            
            cbOffice.Items.Clear();
            for (int i = 0; i < offices.Count; i++)
            {
                cbOffice.Items.Add(offices[i].Location);
            }
        }

        private void btnNewDepartment_Click(object sender, EventArgs e)
        {
            string name = tbDepartmentName.Text;
            string chosenOffice = cbOfficeDepartment.Text;

            Department department = new Department(name, chosenOffice);
            List<Department> departments = department.GetAllDepartments();

            departments.Add(department);

            cbDepartment.Items.Clear();
            for (int i = 0; i < departments.Count; i++)
            {
                cbDepartment.Items.Add(departments[i].Name);
            }
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
