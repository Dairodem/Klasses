using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening4
{
    public partial class Form1 : Form
    {
        Zwembad myZwembad = new Zwembad();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            myZwembad.Length = Convert.ToDouble(txtLength.Text);
            myZwembad.Width = Convert.ToDouble(txtWidth.Text);
            myZwembad.Depth = Convert.ToDouble(txtDepth.Text);

            lblVolume.Text = myZwembad.GetVolume().ToString();
        }
    }
}
