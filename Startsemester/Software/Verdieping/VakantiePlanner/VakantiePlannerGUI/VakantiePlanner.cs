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
    public partial class VakantiePlanner : Form
    {
        // Empty constructors
        Company company = new Company();
        Office office = new Office();
        Department department = new Department();

        int selectedOffice = -1;
        int selectedDepartment = -1;

        #region add to combobox
        private void AddOfficesToComboBox()
        {
            cbOffice.Items.Clear();
            cbDepartmentOffice.Items.Clear();
            cbEmployeeOffice.Items.Clear();
            foreach (var office in company.GetAllOffices())
            {
                cbOffice.Items.Add(office.Location);
                cbDepartmentOffice.Items.Add(office.Location);
                cbEmployeeOffice.Items.Add(office.Location);
            }
        }

        private void AddDepartmentsToComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.Items.Clear();
            office = company.GetAllOffices()[selectedOffice];
            foreach (var department in office.GetAllDepartments())
            {
                comboBox.Items.Add(department.Name);
            }
        }

        private void AddEmployeesToComboBox()
        {
            cbEmployee.Items.Clear();
            department = office.GetAllDepartments()[selectedDepartment];
            foreach (var employee in department.GetAllEmployees())
            {
                cbEmployee.Items.Add(employee.Name);
            }
        }
        #endregion

        #region new .. functions
        private void NewOffice()
        {
            string location = tbOfficeLocation.Text;
            Console.WriteLine(company.TryAddOffice(location));
            AddOfficesToComboBox();
            ResetOfficeInput();
        }

        private void ResetOfficeInput()
        {
            tbOfficeLocation.ResetText();
        }

        private void NewDepartment()
        {
            string departmentName = tbDepartmentName.Text;
            selectedOffice = cbDepartmentOffice.SelectedIndex;
            if (selectedOffice != -1)
            {
                office = company.GetAllOffices()[selectedOffice];
                Console.WriteLine(office.TryAddDepartment(departmentName));
                AddDepartmentsToComboBox(cbDepartment);
                ResetDepartmentInput();
            }
            else
            {
                MessageBox.Show("selecteer eerst een kantoor");
            }
        }

        private void ResetDepartmentInput()
        {
            cbDepartmentOffice.ResetText();
            tbDepartmentName.ResetText();
        }

        private void NewEmployee()
        {
            string employeeName = tbEmployeeName.Text;
            string employeeEmail = tbEmployeeEmail.Text;
            selectedOffice = cbEmployeeOffice.SelectedIndex;
            selectedDepartment = cbEmployeeDepartment.SelectedIndex;
            if (selectedOffice != -1 && selectedDepartment != -1)
            {
                department = office.GetAllDepartments()[selectedDepartment];
                Console.WriteLine(department.TryAddEmployee(employeeName, employeeEmail));
                AddEmployeesToComboBox();
                ResetEmployeeInput();
            }
            else
            {
                MessageBox.Show("selecteer eerst een kantoor en een department");
            }
        }

        private void ResetEmployeeInput()
        {
            cbEmployeeOffice.ResetText();
            cbEmployeeDepartment.ResetText();
            tbEmployeeName.ResetText();
            tbEmployeeEmail.ResetText();
        }
        #endregion

        public VakantiePlanner()
        {
            InitializeComponent();
            AddOfficesToComboBox();
        }

        #region btn new object
        private void btnNewOffice_Click(object sender, EventArgs e)
        {
            NewOffice();
        }

        private void btnNewDepartment_Click(object sender, EventArgs e)
        {
            NewDepartment();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            NewEmployee();
        }
        #endregion

        private void cbOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOffice = cbOffice.SelectedIndex;
            AddDepartmentsToComboBox(cbDepartment);
            selectedOffice = 0;
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDepartment = cbDepartment.SelectedIndex;
            AddEmployeesToComboBox();
            selectedDepartment = 0;
        }

        private void cbEmployeeOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOffice = cbEmployeeOffice.SelectedIndex;
            AddDepartmentsToComboBox(cbEmployeeDepartment);
            selectedOffice = 0;
        }

        private void cbEmployeeDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDepartment = cbEmployeeDepartment.SelectedIndex;
        }

        private void cbDepartmentOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOffice = cbEmployeeOffice.SelectedIndex;
            selectedOffice = 0;
        }
    }
}
