using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTelevisie_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0;
        int HuidigeZender = 0;
        string[] zenders = new string[100];

        private void Form1_Load(object sender, EventArgs e)
        {
            VoegZendersToe();
        }

        public void VoegZendersToe()
        {
            // array stond eerst boven VoegZendersToe(); in Form1_Load
            zenders[0] = "NPO1";
            zenders[1] = "NPO2";
            zenders[2] = "NPO3";

            if (zenders.Contains(tbNieuweZender.Text) == false && tbNieuweZender.Text != "")
            {
                zenders[count] = tbNieuweZender.Text;
            }
            while (zenders[count] != null) // eerste wat ik toevoegde om de zenders in de array te zetten. functie heette eerst "addZenders"
            {
                lbZenders.Items.Add(zenders[count]);
                count++;
            }
            tbNieuweZender.Text = "";
        }

        private void rbAan_CheckedChanged(object sender, EventArgs e)
        {
            lblUitAan.Text = "AAN";
            lblUitAan.BackColor = Color.Green;
            lblZender.Text = zenders[0].ToString();
        }

        private void rbUit_CheckedChanged(object sender, EventArgs e)
        {
            lblUitAan.Text = "UIT";
            lblUitAan.BackColor = Color.Red;
            lblZender.Text = "";
        }

        private void btnVoegZenderToe_Click(object sender, EventArgs e)
        {
            VoegZendersToe();
        }

        private void btnVorige_Click(object sender, EventArgs e)
        {
            while (HuidigeZender > 0)
            {
                lblZender.Text = zenders[HuidigeZender - 1].ToString();
                HuidigeZender = HuidigeZender - 1;
                break;
            }
            /* while (zenders[HuidigeZender] != null)
            {
                HuidigeZender = HuidigeZender + 1;
                if (zenders[HuidigeZender] == null)
                {
                    lblZender.Text = zenders[HuidigeZender - 1].ToString();
                    HuidigeZender = HuidigeZender - 1;
                }
            } */
        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {
            if (zenders[HuidigeZender + 1] != null)
            {
                lblZender.Text = zenders[HuidigeZender + 1].ToString();
                HuidigeZender = HuidigeZender + 1;
            }
            else
            {
                HuidigeZender = 0;
                lblZender.Text = zenders[HuidigeZender].ToString();
            }
        }

        #region onnodig?
        private void lblUitAan_Click(object sender, EventArgs e)
        {

        }

        private void lblZender_Click(object sender, EventArgs e)
        {

        }

        private void lbZenders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbNieuweZender_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
