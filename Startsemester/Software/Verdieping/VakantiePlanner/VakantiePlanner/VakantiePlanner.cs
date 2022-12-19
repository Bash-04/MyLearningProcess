using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VakantiePlannerDAL;
using VakantiePlannerModules;

namespace VakantiePlanner
{
    public partial class VakantiePlanner : Form
    {
        public VakantiePlanner()
        {
            InitializeComponent();
        }

        OfficeDAL officeDAL = new OfficeDAL();
        DepartmentDAL departmentDAL = new DepartmentDAL();
        EmployeeDAL employeeDAL = new EmployeeDAL();

        private void GetAllOffices()
        {
            List<Office> offices = officeDAL.GetAllOffices();
            for (int i = 0; i < offices.Count; i++)
            {
                cbOffice.Items.Add(offices[i].Location);
                cbEmployeeOffice.Items.Add(offices[i].Location);
            }
        }

        private void GetAllDepartments(System.Windows.Forms.ComboBox comboBox, System.Windows.Forms.ComboBox comboBoxOffice)
        {
            int cbIndex = comboBox.SelectedIndex;
            List<Department> departments = departmentDAL.GetAllDepartments();
            if (comboBoxOffice.SelectedIndex != -1)
            {
                comboBox.Items.Clear();
                for (int i = 0; i < departments.Count; i++)
                {
                    //if (comboBox == cbEmployeeDepartment || departments[i].numberOfEmployees != 0)
                    //{
                        comboBox.Items.Add(departments[i].Name);
                    //}
                }
            }
            comboBox.SelectedIndex = cbIndex;
        }

        private void GetAllEmployees()
        {
            List<Employee> employees = employeeDAL.GetAllEmployees();
            if (cbOffice.SelectedIndex != -1 && cbDepartment.SelectedIndex != -1)
            {
                cbEmployee.Items.Clear();
                for (int i = 0; i < employees.Count; i++)
                {
                    if (cbDepartment.SelectedIndex + 1 == employees[i].DepartmentId && cbOffice.SelectedIndex + 1 == employees[i].OfficeId)
                    {
                        cbEmployee.Items.Add(employees[i].Name);
                    }
                }
            }
        }

        private void AddNewOffice()
        {
            string location = tbOfficeName.Text;
            string solicitor = tbOfficeSolicitor.Text;

            bool newOffice = officeDAL.AddNewOffice(location, solicitor);

            List<Office> offices = officeDAL.GetAllOffices();

            cbOffice.Items.Clear();
            cbEmployeeOffice.Items.Clear();
            for (int i = 0; i < offices.Count; i++)
            {
                cbOffice.Items.Add(offices[i].Location);
                cbEmployeeOffice.Items.Add(offices[i].Location);
            }

            tbOfficeName.ResetText();
            tbOfficeSolicitor.ResetText();
        }

        private void AddNewEmployee()
        {
            if (cbEmployeeOffice.SelectedIndex != -1 && cbEmployeeDepartment.SelectedIndex != -1 && tbEmployeeName.Text != "" && tbEmployeeEmail.Text != "")
            {
                int officeId = cbEmployeeOffice.SelectedIndex + 1;
                int departmentId = cbEmployeeDepartment.SelectedIndex + 1;
                string name = tbEmployeeName.Text;
                string email = tbEmployeeEmail.Text;

                bool newEmployee = employeeDAL.AddNewEmployee(name, email, departmentId, officeId);

                employeeDAL.UpdateNumberOfEmployees(officeId);

                GetAllEmployees();
            }

            cbEmployeeOffice.ResetText();
            cbEmployeeDepartment.ResetText();
            tbEmployeeName.ResetText();
            tbEmployeeEmail.ResetText();
        }

        private void AddNewDepartment()
        {
            string name = tbDepartmentName.Text;

            Department department = new Department(name);
            List<Department> departments = department.GetAllDepartments();

            departments.Add(department);

            cbDepartment.Items.Clear();
            for (int i = 0; i < departments.Count; i++)
            {
                cbDepartment.Items.Add(departments[i].Name);
            }

            tbDepartmentName.ResetText();
        }

        private void VakantiePlanner_Load(object sender, EventArgs e)
        {
            GetAllOffices();
            GetAllDepartments(cbDepartment, cbOffice);
            GetAllEmployees();
        }

        private void Calender_DateChanged(object sender, DateRangeEventArgs e)
        {
            Console.WriteLine(Calender.SelectionRange);
        }

        private void btnNewOffice_Click(object sender, EventArgs e)
        {
            AddNewOffice();
        }

        private void btnNewDepartment_Click(object sender, EventArgs e)
        {
            AddNewDepartment();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            AddNewEmployee();
        }

        private void cbOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllDepartments(cbDepartment, cbOffice);
            GetAllEmployees();
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllEmployees();
        }

        private void cbEmployeeOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllDepartments(cbEmployeeDepartment, cbEmployeeOffice);
        }

        private void btnNewHoliday_Click(object sender, EventArgs e)
        {

        }
    }
}
