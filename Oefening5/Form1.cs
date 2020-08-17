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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            School newSchool1 = new School("KTA");
            School newSchool2 = new School("Immaculata");

            RandomName rndName = new RandomName();

            Name = rndName.GetRandomName();

            scholenList.Add(newSchool1);
            scholenList.Add(newSchool2);

            UpdateSchoolList();
            UpdateJaarList();
            UpdateRichtingList(scholenList[cbSchool.SelectedIndex]);

        }
        private void cbSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update leerlingen list op basis van school, jaar, klas.
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

    }
}
