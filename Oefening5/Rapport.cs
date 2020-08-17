using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening5
{
    class Rapport
    {
        public List<Vak> VakkenList { get; set; }
        public Rapport()
        {
            VakkenList = new List<Vak>();
            VakkenList.Add(new Vak("Aardrijkskunde"));
            VakkenList.Add(new Vak("Wiskunde"));
        }

    }
}
