using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class Form1 : Form
    {
        Televisie Tv = new Televisie();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateChannel();
            UpdateVol();
        }

        private void btnChannelUp_Click(object sender, EventArgs e)
        {
            if (Tv.Channel < Tv.maxChannels-1)
            {
                Tv.Channel++;
            }
            else
            {
                Tv.Channel = 0;
            }
            UpdateChannel();
        }

        private void btnChannelDown_Click(object sender, EventArgs e)
        {
            if (Tv.Channel > 0)
            {
                Tv.Channel--;
            }
            else
            {
                Tv.Channel = Tv.maxChannels-1;
            }

            UpdateChannel();

        }
        private void UpdateChannel()
        {
            lblChannel.Text = Tv.channelNames[Tv.Channel];

        }
        private void UpdateVol()
        {
            lblVol.Text = Tv.Volume.ToString();
        }

        private void btnVolUp_Click(object sender, EventArgs e)
        {
            if (Tv.Volume < Tv.maxChannels)
            {
                Tv.Volume++;
            }

            UpdateVol();
        }

        private void btnVolDown_Click(object sender, EventArgs e)
        {
            if (Tv.Volume > 0)
            {
                Tv.Volume--;
            }

            UpdateVol();
        }
    }
}
