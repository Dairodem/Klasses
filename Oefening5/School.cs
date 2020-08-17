using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening5
{
    class School
    {
        public string Name { get; set; }
        public List<Klas> KlassenList { get; }

        public School(string name)
        {
            Name = name;

            KlassenList = new List<Klas>();
            AddToList(new Klas("Economie"));
            AddToList(new Klas("Wiskunde-Talen"));
            AddToList(new Klas("Wetenschappen"));
            AddToList(new Klas("InformaticaBeheer"));
        }
        private void AddToList(Klas klas)
        {
            KlassenList.Add(klas);
        }
    }
}
