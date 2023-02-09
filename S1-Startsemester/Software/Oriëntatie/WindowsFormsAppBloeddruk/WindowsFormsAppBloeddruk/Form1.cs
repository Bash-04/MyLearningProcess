using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppBloeddruk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int systolisch;
        int diastolisch;
        int gemiddeld;

        #region Unused function
        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBovendruk_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOnderdruk_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResNaam_Click(object sender, EventArgs e)
        {

        }

        private void lblResLeeftijd_Click(object sender, EventArgs e)
        {

        }

        private void lblResBloeddruk_Click(object sender, EventArgs e)
        {

        }

        private void lblResBloeddrukWaarde_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region commented function
        /*
        public void genderBackgr()
        {
            if(rbGenderMale.Checked == true)
            {
                BackColor = Color.LightBlue;
            }
            else if(rbGenderFemale.Checked == true)
            {
                BackColor = Color.Pink;
            }
        }
        */
        #endregion

        private void rbGenderMale_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }

        private void rbGenderFemale_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Pink;
        }

        public void nameAndAge()
        {
            if((tbName.Text == "") == false)
            {
                lblResNaam.Text = tbName.Text;
            }
            else
            {
                MessageBox.Show("Vul alstublieft uw naam in.");
            }
            if((tbAge.Text == "") == false)
            {
                lblResLeeftijd.Text = tbAge.Text;
            }
            else
            {
                MessageBox.Show("Vul alstublieft uw leeftijd in.");
            }
        }

        public void bloeddruk()
        {
            systolisch = Convert.ToInt32(tbBovendruk.Text);
            diastolisch = Convert.ToInt32(tbOnderdruk.Text);
            gemiddeld = diastolisch + ((systolisch - diastolisch) / 3);
            lblResBloeddruk.Text = gemiddeld.ToString();
        }

        public void bloeddrukWaarde()
        {
            if(gemiddeld <= 70)
            {
                lblResBloeddrukWaarde.Text = "laag";
            }
            else if (gemiddeld <= 89)
            {
                lblResBloeddrukWaarde.Text = "gemiddel";
            }
            else if (gemiddeld <= 96)
            {
                lblResBloeddrukWaarde.Text = "optimaal";
            }
            else if (gemiddeld <= 112)
            {
                lblResBloeddrukWaarde.Text = "gemiddel";
            }
            else if(gemiddeld >= 113)
            {
                lblResBloeddrukWaarde.Text = "hoog";
            }
        }

        public void LeeftijdMax()
        {
            int resLeeftijd = Convert.ToInt32(lblResLeeftijd.Text);
            if (rbGenderMale.Checked == true)
            {
                if (gemiddeld >= 113 && resLeeftijd > 65)
                {
                    MessageBox.Show("Patiënt heeft extra aandacht nodig.");
                }
            }
            else if (rbGenderFemale.Checked == true)
            {
                if (gemiddeld >= 113 && resLeeftijd > 67)
                {
                    MessageBox.Show("Patiënt heeft extra aandacht nodig.");
                }
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            /*  genderBackgr();   */
            nameAndAge();
            bloeddruk();
            bloeddrukWaarde();
            LeeftijdMax();
        }

    }
}
