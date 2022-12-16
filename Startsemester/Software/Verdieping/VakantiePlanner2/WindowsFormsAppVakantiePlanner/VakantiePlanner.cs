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

namespace WindowsFormsAppVakantiePlanner
{
    public partial class VakantiePlanner : Form
    {
        public VakantiePlanner()
        {
            InitializeComponent();
        }

        private void VakantiePlanner_Load(object sender, EventArgs e)
        {
            Office office = new Office("Gemert");
            office.AddOffice("Gemert");
            cbOffice.Items.Add(office);
        }

        private void Calender_DateChanged(object sender, DateRangeEventArgs e)
        {
            Console.WriteLine(Calender.SelectionRange);
        }
    }
}
