using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening5
{
    class Klas
    {
        public string Name { get; set; }
        public List<Leerling> LeerlingenList { get; }
        public Klas(string name)
        {
            Name = name;
        }
        public void AddStudent(Leerling student)
        {
            LeerlingenList.Add(student);
        }

    }
}
