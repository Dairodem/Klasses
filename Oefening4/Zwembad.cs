using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening4
{
    class Zwembad
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume { get; }

        public Zwembad()
        {
            Length = 1;
            Width = 1;
            Depth = 1;
        }
        public double GetVolume()
        {
            double volume = Length * Width * Depth;

            return volume;
        }
    }
}
