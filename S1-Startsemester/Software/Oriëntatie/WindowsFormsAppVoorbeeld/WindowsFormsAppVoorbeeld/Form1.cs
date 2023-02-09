using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppVoorbeeld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int leesGetal(string getalOmTeLezen)
        {
            int getalUitkomst = 0;
            if (getalOmTeLezen == "")
            {
                MessageBox.Show("Vul een getal in in de textbox");
            }
            else
            {
                if (int.TryParse(getalOmTeLezen, out getalUitkomst) == false)
                {
                    MessageBox.Show("Vul een geheel getal in in de textbox");
                }
            }
            return getalUitkomst;
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            int getal1;
            getal1 = leesGetal(tbGetal1.Text);

            int getal2;
            getal2 = leesGetal(tbGetal2.Text);

            int uitkomst = 0;
            if (rbPlus.Checked == true)
            {
                uitkomst = getal1 + getal2;
            }
            else if(rbMin.Checked == true)
            {
                uitkomst= getal1 - getal2;
            }
            else if(rbKeer.Checked == true)
            {
                uitkomst = getal1 * getal2;
            }
            else
            {
                MessageBox.Show("check math method!");
            }
            lbUitkomsten.Items.Add(uitkomst);

            berekenTotaal();
        }

        public void berekenTotaal()
        {
            int totaal = 0;
            for (int i = 0; i < lbUitkomsten.Items.Count; i++)
            {
                totaal = totaal + (int) lbUitkomsten.Items[i];
            }
            lblTotaal.Text = totaal.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Ongebruikte functies

        private void tbGetal1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbGetal2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbPlus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbKeer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbUitkomsten_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTotaal_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
