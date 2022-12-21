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
        Office office = new Office();
        Department department = new Department();

        int selectedOffice = -1;

        #region add to combobox
        private void AddOfficesToComboBox()
        {
            cbOffice.Items.Clear();
            cbDepartmentOffice.Items.Clear();
            cbEmployeeOffice.Items.Clear();
            foreach (var office in office.GetAllOffices())
            {
                cbOffice.Items.Add(office.Location);
                cbDepartmentOffice.Items.Add(office.Location);
                cbEmployeeOffice.Items.Add(office.Location);
            }
        }

        private void AddDepartmentsToComboBox()
        {
            cbDepartment.Items.Clear();
            foreach (var department in office.GetAllDepartments())
            {
                cbDepartment.Items.Add(department.Name);
            }
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
            string location = tbOfficeLocation.Text;
            MessageBox.Show(office.TryAddOffice(location));
            AddOfficesToComboBox();
            tbOfficeLocation.ResetText();
            cbOffice.SelectedIndex = 0;
        }

        private void btnNewDepartment_Click(object sender, EventArgs e)
        {
            string departmentName = tbDepartmentName.Text;
            selectedOffice = cbDepartmentOffice.SelectedIndex;
            if (selectedOffice != -1)
            {
                office = office.GetAllOffices()[selectedOffice];
                MessageBox.Show(office.TryAddDepartment(departmentName));
                AddDepartmentsToComboBox();
                tbDepartmentName.ResetText();
            }
            else
            {
                MessageBox.Show("selecteer eerst een kantoor");
            }
        }
        #endregion

        private void cbOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOffice = cbOffice.SelectedIndex;
        }
    }
}
