using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening5
{
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Leerling newLeerling = new Leerling(txtNewName.Text);
            if (numAge.Value != 0)
            {
                newLeerling.Age = (int)numAge.Value;
            }
            if (txtNewGender != null)
            {
                newLeerling.Gender = txtNewGender.Text;
            }
            Close();
        }
    }
}
