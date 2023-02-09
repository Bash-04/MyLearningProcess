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

        #region Main DAL objects
        OfficeDAL officeDAL = new OfficeDAL();
        DepartmentDAL departmentDAL = new DepartmentDAL();
        EmployeeDAL employeeDAL = new EmployeeDAL();
        HolidayDAL holidayDAL = new HolidayDAL();
        #endregion

        #region Getter methods
        private List<Office> GetAllOffices()
        {
            List<Office> offices = officeDAL.GetAllOffices();
            cbOffice.Items.Clear();
            cbEmployeeOffice.Items.Clear();
            foreach (var office in offices)
            {
                cbOffice.Items.Add(office.Location);
                cbEmployeeOffice.Items.Add(office.Location);
            }
            return offices;
        }

        private List<Department> GetAllDepartments(System.Windows.Forms.ComboBox comboBox, System.Windows.Forms.ComboBox comboBoxOffice)
        {
            int cbIndex = comboBox.SelectedIndex;
            List<Department> departments = departmentDAL.GetAllDepartments();
            if (comboBoxOffice.SelectedIndex != -1)
            {
                comboBox.Items.Clear();
                foreach (var department in departments)
                {
                    if (department.NumberOfEmployees!= 0 || comboBox == cbEmployeeDepartment)
                    {
                        comboBox.Items.Add(department.Name);
                    }
                }
            }
            comboBox.SelectedIndex = cbIndex;
            return departments;
        }

        private List<Employee> GetAllEmployees()
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
            return employees;
        }
        #endregion

        #region Adding methods
        private void AddNewOffice()
        {
            if (tbOfficeName.Text == null && tbOfficeSolicitor.Text == null)
            {
                string location = tbOfficeName.Text;
                string solicitor = tbOfficeSolicitor.Text;

                officeDAL.AddNewOffice(location, solicitor);

                GetAllOffices();
            }

            tbOfficeName.ResetText();
            tbOfficeSolicitor.ResetText();
        }

        private void AddNewDepartment()
        {
            if (tbDepartmentName.Text == "")
            {
                string name = tbDepartmentName.Text;

                Department department = new Department(name);
                List<Department> departments = department.GetAllDepartments();

                departments.Add(department);

                GetAllDepartments(cbDepartment, cbOffice);
            }

            tbDepartmentName.ResetText();
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

                UpdateNumberOfEmployees();

                GetAllEmployees();
            }

            cbEmployeeOffice.ResetText();
            cbEmployeeDepartment.ResetText();
            tbEmployeeName.ResetText();
            tbEmployeeEmail.ResetText();
        }

        private void AddHoliday()
        {
            Console.WriteLine(Calender.SelectionRange);
            Holiday holiday = new Holiday(Calender.SelectionStart, Calender.SelectionEnd);
            Console.WriteLine(holiday.Duration);
        }
        #endregion

        #region Update methods
        private bool UpdateNumberOfEmployees()
        {
            bool result = false;

            int i = 0;
            while (i <= officeDAL.GetAllOffices().Count || i <= departmentDAL.GetAllDepartments().Count)
            {
                employeeDAL.UpdateNumberOfEmployeesOffice(i);
                employeeDAL.UpdateNumberOfEmployeesDepartment(i);
                i++;
                result = true;
            }

            return result;
        }
        #endregion

        private void VakantiePlanner_Load(object sender, EventArgs e)
        {
            GetAllOffices();
            GetAllDepartments(cbDepartment, cbOffice);
            GetAllEmployees();
            UpdateNumberOfEmployees();
        }

        #region btn New Office/Department/Employee/Holiday
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

        private void btnNewHoliday_Click(object sender, EventArgs e)
        {
            AddHoliday();
        }

        private void btnGetAllHolidays_Click(object sender, EventArgs e)
        {
            List<Employee> employees = employeeDAL.GetAllEmployees();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }
            dgvHolidays.DataSource = holidayDAL.GetAllHolidays();
        }
        #endregion

        #region comboBox SelectedIndexChanged
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
        #endregion
    }
}
