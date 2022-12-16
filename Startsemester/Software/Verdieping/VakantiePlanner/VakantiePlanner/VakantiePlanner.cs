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

        private void VakantiePlanner_Load(object sender, EventArgs e)
        {
            GetAllOffices();
            //office.AddOffice(office);
        }

        private void Calender_DateChanged(object sender, DateRangeEventArgs e)
        {
            Console.WriteLine(Calender.SelectionRange);
        }
    }
}
