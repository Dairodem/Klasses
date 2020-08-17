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
    public partial class Form1 : Form
    {
        List<School> scholenList = new List<School>();
        public string[] studieJaarArr = new string[] { "Eerste", "Tweede", "Derde", "Vierde", "Vijde", "Zesde" };

        int schoolIndex = 0;
        int richtingIndex = 0;
        int studentIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            School newSchool1 = new School("KTA");
            School newSchool2 = new School("Immaculata");

            scholenList.Add(newSchool1);
            scholenList.Add(newSchool2);

            UpdateAll();


        }
        private void cbSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRichtingList(scholenList[cbSchool.SelectedIndex]);
            UpdateLeerlingenList(scholenList[cbSchool.SelectedIndex].KlassenList[cbRichting.SelectedIndex]);
            


        }
        private void cbRichting_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLeerlingenList(scholenList[cbSchool.SelectedIndex].KlassenList[cbRichting.SelectedIndex]);
            

        }
        private void btnNewStudent_Click_1(object sender, EventArgs e)
        {
            scholenList[cbSchool.SelectedIndex].KlassenList[cbRichting.SelectedIndex].LeerlingenList.Add(new Leerling(txtAddStudent.Text));
            UpdateLeerlingenList(scholenList[cbSchool.SelectedIndex].KlassenList[cbRichting.SelectedIndex]);
            MessageBox.Show(scholenList[cbSchool.SelectedIndex].KlassenList[cbRichting.SelectedIndex].Name);

        }
        private void cbLeerling_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateVakkenList();
        }
        private void btnAddPunten_Click(object sender, EventArgs e)
        {
            scholenList[cbSchool.SelectedIndex].KlassenList[cbRichting.SelectedIndex].LeerlingenList[cbLeerling.SelectedIndex].MyRapport.VakkenList[cbVakken.SelectedIndex].puntenList.Add(Convert.ToDouble(txtAddPunten.Text));
            UpdatePuntenList();
        }
        private void cbVakken_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePuntenList();
        }

        private void UpdateSchoolList()
        {
            cbSchool.Items.Clear();

            foreach (School school in scholenList)
            {
                cbSchool.Items.Add(school.Name);
            }

            cbSchool.SelectedIndex = 0;
        }
        private void UpdateJaarList()
        {
            cbJaar.Items.Clear();

            for (int i = 0; i < studieJaarArr.Length; i++)
            {
                cbJaar.Items.Add(studieJaarArr[i]);
            }

            cbJaar.SelectedIndex = 0;

        }
        private void UpdateRichtingList(School school)
        {
            cbRichting.Items.Clear();

            foreach (Klas klas in school.KlassenList)
            {
                cbRichting.Items.Add(klas.Name);
            }

            cbRichting.SelectedIndex = 0;

        }
        private void UpdateLeerlingenList(Klas klas)
        {
            if (klas.LeerlingenList.Count > 0)
            {
                cbLeerling.Items.Clear();

                foreach (Leerling leerling in klas.LeerlingenList)
                {
                    cbLeerling.Items.Add(leerling.Name);
                }

                cbLeerling.SelectedIndex = 0;

            }
            UpdateVakkenList();

        }
        private void UpdateVakkenList()
        {
            cbVakken.DataSource = null;
            cbVakken.DataSource = scholenList[cbSchool.SelectedIndex].KlassenList[cbRichting.SelectedIndex].LeerlingenList[cbLeerling.SelectedIndex].MyRapport.VakkenList;

            //UpdatePuntenList();

        }
        private void UpdatePuntenList()
        {
            lbPunten.DataSource = null;
            lbPunten.DataSource = scholenList[cbSchool.SelectedIndex].KlassenList[cbRichting.SelectedIndex].LeerlingenList[cbLeerling.SelectedIndex].MyRapport.VakkenList[cbVakken.SelectedIndex].puntenList;
        }
        private void UpdateAll()
        {
            UpdateSchoolList();
            UpdateJaarList();
            UpdateRichtingList(scholenList[cbSchool.SelectedIndex]);
            UpdateLeerlingenList(scholenList[cbSchool.SelectedIndex].KlassenList[cbRichting.SelectedIndex]);
            UpdateVakkenList();
            UpdatePuntenList();
        }

    }
}
