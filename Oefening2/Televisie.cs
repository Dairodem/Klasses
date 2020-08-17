using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    class Televisie
    {

        public int Volume { get; set; }
        public int Channel { get; set; }

        public int maxChannels = 10;
        public int maxVol = 15;

        public List<string> channelNames = new List<string>();

        public Televisie()
        {
            Volume = 7;
            Channel = 1;

            channelNames.Add("VTM");
            channelNames.Add("Een");
            channelNames.Add("2BE");
            channelNames.Add("4");
            channelNames.Add("VijfTv");
            channelNames.Add("RTBF");
            channelNames.Add("BBC 1");
            channelNames.Add("BBC 2");
            channelNames.Add("ZDF");
            channelNames.Add("Arte");
        }

    }
}
