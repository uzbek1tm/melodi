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
    public partial class fWin : Form
    {
       
        fParam p = new fParam();
        public fWin()
        {
            InitializeComponent();
        }

        private void fWin_Load(object sender, EventArgs e)
        {
            Victorina.ReadParam();
            Victorina.ReadParam1();
            if (Victorina.playerCount1 == Victorina.PlayerCount2)
            {       label1.Text = "Ничья";
            lbWin.Visible = false;
            lbLose.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
            }
            else
            {
                lbWin.Visible = true;
                lbLose.Visible = true;
                label1.Text = "Результаты";
                label2.Visible = true;
                label3.Visible = true;
                if (Victorina.playerCount1 > Victorina.PlayerCount2)
                {
                    lbWin.Text = Victorina.playerName1;
                    lbLose.Text = Victorina.playerName2;
                    Victorina.PlayerWiner = lbWin.Text;
                    Victorina.Winercount = Victorina.playerCount1;

                }
                else
                {
                    lbWin.Text = Victorina.playerName2;
                    lbLose.Text = Victorina.playerName1;
                    Victorina.PlayerWiner = lbWin.Text;
                    Victorina.Winercount = Victorina.PlayerCount2;
                }
                Victorina.WritePlayerName1();
            }
            
        }
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"1.wav");
        private void button1_Click(object sender, EventArgs e)
        {
            sp.Play();
                this.Close();
                Victorina.ReadParam();
                p.cbAllDiry.Checked = Victorina.allDirestry;
                p.cbGame.Text = Victorina.gameDuraction.ToString();
                p.cbMusic.Text = Victorina.musicDusraction.ToString();
                p.cbRandom.Checked = Victorina.random;
                Victorina.ReadMusic();
                Victorina.ReadParam2();
            
            
        }
    }
}
