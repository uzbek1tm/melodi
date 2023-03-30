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

    public partial class Fmain : Form
    {
        fParam fp = new fParam();
        fPlay fp1 = new fPlay();
        fPlayerParam fpp = new fPlayerParam();
        Record fr = new Record();
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"1.wav"); 
        public Fmain()
        {
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParam_Click(object sender, EventArgs e)
        {
            
           fp.ShowDialog();
            
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            sp.Stop();
            fpp.ShowDialog();
            
        }
        
        private void Fmain_Load(object sender, EventArgs e)
        {
            sp.Play();
            Victorina.ReadParam();
            Victorina.ReadMusic();
            Victorina.ReadParam2();
            
        }

        private void Fmain_Shown(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fr.ShowDialog();
        }
    }
}
