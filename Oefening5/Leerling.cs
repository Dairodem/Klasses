using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening5
{
    class Leerling
    {
        public string Name { get ;set ; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Rapport MyRapport { get; set; }

        public Leerling(string name)
        {
            Name = name;
            Age = -1;
            Gender = "-";
            MyRapport = new Rapport();

        }
    }
}
