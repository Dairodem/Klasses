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
        RandomName rndName = new RandomName();
        public Klas(string name)
        {
            LeerlingenList = new List<Leerling>();

            string stName = rndName.GetRandomName();
            Name = name;
            AddStudent(new Leerling(stName));
        }
        public void AddStudent(Leerling student)
        {
            LeerlingenList.Add(student);
        }

    }
}
