using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace melodi
{
    public partial class fPlayerParam : Form
    {
        fPlay qw = new fPlay();
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"1.wav");
        public fPlayerParam()
        {
            InitializeComponent();
        }

        private void btnplayerCANCLE_Click(object sender, EventArgs e)
        {
            sp.Play();
            this.Hide();

        }
        void set()
        {
            Victorina.ReadParam();
            txplayer1.Text =  Victorina.playerName1;
            txplayer2.Text = Victorina.playerName2;

        }
        private void fPlayerParam_Load(object sender, EventArgs e)
        {
            set();
        }

        private void btnplayerOK_Click(object sender, EventArgs e)
        {
             Victorina.playerName1= txplayer1.Text;
             Victorina.playerName2 = txplayer2.Text;
            Victorina.WritePlayerName();
            this.Hide();
            qw.ShowDialog();
            
        }
    }
}
