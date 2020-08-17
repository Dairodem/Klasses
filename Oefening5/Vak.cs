using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening5
{
    class Vak
    {
        public List<double> puntenList { get; set; }
        public string Name { get; set; }

        public Vak(string name)
        {
            Name = name;
            puntenList = new List<double>();
            puntenList.Add(20);
        }
        public double GetMedian(List<double> puntenList)
        {
            double median = 0;

            for (int teller = 0; teller < puntenList.Count - 1; teller++)
            {
                median += puntenList[teller];

            }

            return median;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
