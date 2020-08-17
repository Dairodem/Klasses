using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening1
{
    class Teller
    {
        private int myTeller = 0;

        public Teller(int teller)
        {
            myTeller = teller;
        }
        public void Bijtellen()
        {
            myTeller++;
        }
        public void Aftrekken()
        {
            myTeller--;
        }
        public void ToonTeller()
        {
            MessageBox.Show(myTeller.ToString());

        }
        public void Reset()
        {
            myTeller = 0;
        }
    }
}
