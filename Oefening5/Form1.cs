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

        int selectedSchool = 0;

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

            UpdateSchoolList();
            UpdateJaarList();
            UpdateRichtingList(scholenList[cbSchool.SelectedIndex]);
            UpdateLeerlingenList(scholenList[cbSchool.SelectedIndex].KlassenList[cbRichting.SelectedIndex]);

        }
        private void cbSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            if (klas.LeerlingenList.Count >0)
            {
                cbLeerling.Items.Clear();

                foreach (Leerling leerling in klas.LeerlingenList)
                {
                    cbLeerling.Items.Add(leerling.Name);
                }

                cbLeerling.SelectedIndex = 0;

            }


        }
        private void button4_Click(object sender, EventArgs e)
        {
            NewStudent newStudent = new NewStudent();

            newStudent.Show();

        }

        private void cbRichting_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLeerlingenList(scholenList[cbSchool.SelectedIndex].KlassenList[cbRichting.SelectedIndex]);

        }
    }
}
