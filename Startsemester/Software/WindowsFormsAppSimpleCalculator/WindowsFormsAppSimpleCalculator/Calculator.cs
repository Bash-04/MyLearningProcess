using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSimpleCalculator
{
    public partial class Calculator : Form
    {
        double eersteGetal = 0;
        double tweedeGetal = 0;
        double antwoord = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtbxGetal1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxGetal2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPLUS_Click(object sender, EventArgs e)
        {
            LeesGetallen();

            antwoord = eersteGetal + tweedeGetal;

            Uitkomst();
        }

        private void btnMIN_Click(object sender, EventArgs e)
        {
            LeesGetallen();

            antwoord = eersteGetal - tweedeGetal;

            Uitkomst();
        }

        private void btnDELEN_Click(object sender, EventArgs e)
        {
            LeesGetallen();

            antwoord = eersteGetal / tweedeGetal;

            Uitkomst();
        }

        private void btnKEER_Click(object sender, EventArgs e)
        {
            LeesGetallen();

            antwoord = eersteGetal * tweedeGetal;

            Uitkomst();
        }

        private void lblANS_Click(object sender, EventArgs e)
        {

        }

        public void LeesGetallen()
        {
            string getal1;
            getal1 = txtbxGetal1.Text;
            eersteGetal = System.Convert.ToDouble(getal1);

            string getal2;
            getal2 = txtbxGetal2.Text;
            tweedeGetal = System.Convert.ToDouble(getal2);
        }

        public void Uitkomst()
        {
            string txtAntwoord = System.Convert.ToString(antwoord);
            lblANS.Text = "Uitkomst: " + txtAntwoord;
        }
    }
}
