using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCurrencyConverter
{
    public partial class CurrencyConverter : Form
    {
        double euro;
        double dollar;
        double koerswaarde;
        double uitkomst;

        public CurrencyConverter()
        {
            InitializeComponent();
        }

        private void btnConv2Euro_Click(object sender, EventArgs e)
        {
            dollar = double.Parse(tbDollar.Text);

            Koerswaard();

            uitkomst =  dollar / koerswaarde;

            uitkomstdec();

            tbEuro.Text = uitkomst.ToString();

        }

        private void btnConv2Dollar_Click(object sender, EventArgs e)
        {
            euro = double.Parse(tbEuro.Text);

            Koerswaard();

            uitkomst =  euro * koerswaarde;

            uitkomstdec();

            tbDollar.Text = uitkomst.ToString();
        }

        public void Koerswaard()
        { 
            koerswaarde = double.Parse(numericUpDown1.Text);
        }

        public void uitkomstdec()
        {
            uitkomst = Math.Round(uitkomst, 3);
        }



        private void tbEuro_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDollar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConverted_Click(object sender, EventArgs e)
        {

        }
    }
}
