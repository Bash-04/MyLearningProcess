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
        Employee employee = new Employee();
        Holiday holiday = new Holiday();

        int selectedOffice = -1;
        int selectedDepartment = -1;
        int selectedEmployee = -1;

        public VakantiePlanner()
        {
            InitializeComponent();
            AddOfficesToComboBox();
        }

        #region add results to GUI
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

        private void AddHolidaysToListBox()
        {
            lbHolidayStartDate.Items.Clear();
            lbHolidayEndDate.Items.Clear();
            lbHolidayDescription.Items.Clear();
            for (int i = 0; i < employee.GetHolidays().Count(); i++)
            {
                lbHolidayStartDate.Items.Add(employee.GetHolidays()[i].StartDate.ToString());
                lbHolidayEndDate.Items.Add(employee.GetHolidays()[i].EndDate.ToString());
                lbHolidayDescription.Items.Add(employee.GetHolidays()[i].Description);
            }
        }
        #endregion

        #region new object functions
        private void NewOffice()
        {
            string location = tbOfficeLocation.Text;
            Console.WriteLine(company.TryAddOffice(location));
            AddOfficesToComboBox();
            ResetOfficeInputFields();
        }

        private void ResetOfficeInputFields()
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
                ResetDepartmentInputFields();
            }
            else
            {
                MessageBox.Show("selecteer eerst een kantoor");
            }
        }

        private void ResetDepartmentInputFields()
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
                ResetEmployeeInputFields();
            }
            else
            {
                MessageBox.Show("selecteer eerst een kantoor en een department");
            }
        }

        private void ResetEmployeeInputFields()
        {
            cbEmployeeOffice.ResetText();
            cbEmployeeDepartment.ResetText();
            tbEmployeeName.ResetText();
            tbEmployeeEmail.ResetText();
        }

        private void PlanNewHoliday()
        {
            DateTime startDate = dateTimePickerHolidayStartDate.Value.Date;
            DateTime endDate = dateTimePickerHolidayEndDate.Value.Date;
            string description = tbHolidayDescription.Text;
            selectedOffice = cbOffice.SelectedIndex;
            selectedDepartment = cbDepartment.SelectedIndex;
            selectedEmployee = cbEmployee.SelectedIndex;

            if (selectedOffice != -1 && selectedDepartment != -1 && selectedEmployee != -1)
            {
                employee = department.GetAllEmployees()[selectedEmployee];
                Console.WriteLine(employee.TryPlanHoliday(startDate, endDate, description));
                AddHolidaysToListBox();
                ResetHolidayInputFields();
            }
            else
            {
                MessageBox.Show("selecteer eerst een kantoor en een department");
            }
        }

        private void ResetHolidayInputFields()
        {
            dateTimePickerHolidayStartDate.ResetText();
            dateTimePickerHolidayEndDate.ResetText();
            tbHolidayDescription.ResetText();
        }
        #endregion

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

        private void btnPlanNewHoliday_Click(object sender, EventArgs e)
        {
            PlanNewHoliday();
        }
        #endregion

        #region ComboBoxen
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
        #endregion

        #region ListBoxen
        private void lbHolidayStartDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbHolidayEndDate.SelectedIndex = lbHolidayStartDate.SelectedIndex;
            lbHolidayDescription.SelectedIndex = lbHolidayStartDate.SelectedIndex;
        }

        private void lbHolidayEndDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbHolidayStartDate.SelectedIndex = lbHolidayEndDate.SelectedIndex;
            lbHolidayDescription.SelectedIndex = lbHolidayEndDate.SelectedIndex;
        }

        private void lbHolidayDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbHolidayStartDate.SelectedIndex = lbHolidayDescription.SelectedIndex;
            lbHolidayEndDate.SelectedIndex = lbHolidayDescription.SelectedIndex;
        }
        #endregion
    }
}
