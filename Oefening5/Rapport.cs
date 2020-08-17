using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening5
{
    class Rapport
    {
        List<double> ptnAard { get;  }
        List<double> ptnGods { get;  }
        List<double> ptnWisk { get;  }
        List<double> ptnFrns { get;  }
        List<double> ptnNed { get; }
        List<double> ptnGes { get; }
        List<double> ptnInf { get; }

        public Rapport()
        {
            ptnAard = new List<double>();
            ptnGods = new List<double>();
            ptnWisk = new List<double>();
            ptnFrns = new List<double>();
            ptnNed = new List<double>();
            ptnGes = new List<double>();
            ptnInf = new List<double>();
        }

        public void AddPoints(List<double> vakkenList, double punten)
        {
            vakkenList.Add(punten);
        }
        public double GetMedian(List<double> vakkenList)
        {
            double median = 0;

            for (int teller = 0; teller < vakkenList.Count-1; teller++)
            {
                median += vakkenList[teller];

            }

            return median;
        }
    }
}
