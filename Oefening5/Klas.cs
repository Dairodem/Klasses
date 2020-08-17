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
        public List<Leerling> LeerlingenList { get; set; }
        public Klas(string name)
        {
            LeerlingenList = new List<Leerling>();

            Name = name;
            AddStudent(new Leerling("Dummy"));
        }
        public void AddStudent(Leerling student)
        {
            LeerlingenList.Add(student);
        }

    }
}
