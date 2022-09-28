using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppWorpengenerator
{
    public partial class Form1 : Form
    {
        int aantalWorpen;
        int aantalOgen;
        int worpen;

        public Form1()
        {
            InitializeComponent();
        }

        #region onnodig

        private void listBoxWorpen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTotaalOgen_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void numericUpDownWorpen_ValueChanged(object sender, EventArgs e)
        {
            aantalWorpen = decimal.ToInt32(numericUpDownWorpen.Value);
        }

        private void numericUpDownOgen_ValueChanged(object sender, EventArgs e)
        {
            aantalOgen = decimal.ToInt32(numericUpDownOgen.Value);
        }

        private void GooiDobbelsteen_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int uitkomst = 0;

            listBoxWorpen.Items.Clear();
            for (int i = 0; i < aantalWorpen; i++)
            {
                worpen = random.Next(1,aantalOgen + 1);
                listBoxWorpen.Items.Add(worpen);
                Console.WriteLine(worpen);
            }

            int[] ttlaantal = listBoxWorpen.Items.OfType<int>().ToArray();

            for (int i = 0; i < ttlaantal.Count(); i++)
            {
                uitkomst = uitkomst + ttlaantal[i];
            }

            lblTotaalOgen.Text = uitkomst.ToString();
        }

    }
}
