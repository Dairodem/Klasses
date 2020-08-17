using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening1
{
    public partial class Form1 : Form
    {
        Teller myTeller = new Teller(0);

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            myTeller.ToonTeller();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            myTeller.Reset();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myTeller.Bijtellen();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            myTeller.Aftrekken();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
