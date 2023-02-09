using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOriëntatie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbnaam_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnnaam_Click(object sender, EventArgs e)
        {
            string naam;
            naam = tbnaam.Text;
            lblnaam.Text = naam;
        }

        private void lblnaam_Click(object sender, EventArgs e)
        {

        }

        int Matha;
        int Mathb;
        int Mathsol;

        private void MathA_TextChanged(object sender, EventArgs e)
        {
            Matha = Convert.ToInt32(Matha);
        }

        private void MathB_TextChanged(object sender, EventArgs e)
        {
            Mathb = Convert.ToInt32(Mathb);
        }

        private void MathAns_Click(object sender, EventArgs e)
        {
            
        }

        private void PLUS_Click(object sender, EventArgs e)
        {

        }

        private void MULTIPLY_Click(object sender, EventArgs e)
        {

        }
    }
}
