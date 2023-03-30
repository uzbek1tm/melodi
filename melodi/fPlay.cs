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
    public partial class fPlay : Form
    {
        Random rnd = new Random();
        int musicdiraty;
        Message m = new Message();
        fParam p = new fParam();
        fWin q = new fWin();
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"1.wav");



        bool[] player = new bool[2];
        public fPlay()
        {
            InitializeComponent();
        }
        void makeMusic()
        {
            if (Victorina.list.Count == 0)

                EndGame();


            else
            {

                musicdiraty = Victorina.musicDusraction;

                int n = rnd.Next(0, Victorina.list.Count);
                WMP.URL = Victorina.list[n];
                Victorina.answer = System.IO.Path.GetFileNameWithoutExtension( WMP.URL);
                Victorina.list.RemoveAt(n);
                Mcount.Text = Victorina.list.Count.ToString();

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            makeMusic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gamepause();
        }

        private void fPlay_FormClosed(object sender, FormClosedEventArgs e)
        {
            WMP.Ctlcontrols.stop();
            timer1.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fPlay_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            Mcount.Text = Victorina.list.Count.ToString();
            progressBar1.Maximum = Victorina.gameDuraction;
            Timer.Text = Convert.ToString(Victorina.musicDusraction);
            player[0] = false;
            player[1] = false;
            Player1.Text = Victorina.playerName1;
            Player2.Text = Victorina.playerName2;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        void EndGame()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
            Victorina.playerCount1 = Convert.ToInt32(oT1.Text);
            Victorina.PlayerCount2 = Convert.ToInt32(oT2.Text);
            Victorina.WritePlayerCount();
            q.ShowDialog();
            oT1.Text = Convert.ToString(0);
            oT2.Text = Convert.ToString(0);

            this.Close();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicdiraty--;
            Timer.Text = Convert.ToString(musicdiraty);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                EndGame();
                return;
            }
            if (musicdiraty == 0) makeMusic();



        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            gameplay();
        }
        void gamepause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }
        void gameplay()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }
        private void fPlay_KeyDown(object sender, KeyEventArgs e)
        {
            if (player[0] == false && e.KeyData == Keys.A)
            {
                if (timer1.Enabled)
                {
                    gamepause();
                    player[0] = true;
                    player[1] = false;
                    m.lbplayer.Text = Victorina.playerName1;
                    if (m.ShowDialog() == DialogResult.Yes)
                    {
                        oT1.Text = Convert.ToString(Convert.ToInt32(oT1.Text) + 1);
                        if (Victorina.list.Count > 0)

                            gameplay();
                        makeMusic();
                    }
                    else
                    {

                        if (Victorina.list.Count > 0)

                            gameplay();
                        makeMusic();
                    }
                }
            }
            if (e.KeyData == Keys.P)
            {
                if (player[1] == false && timer1.Enabled)
                {
                    gamepause();
                    player[1] = true;
                    player[0] = false;
                    m.lbplayer.Text = Victorina.playerName2;
                    if (m.ShowDialog() == DialogResult.Yes)
                    {
                        oT2.Text = Convert.ToString(Convert.ToInt32(oT2.Text) + 1);
                        if (Victorina.list.Count > 0)

                            gameplay();
                        makeMusic();
                    }
                    else
                    {

                        if (Victorina.list.Count > 0)

                            gameplay();
                        makeMusic();
                    }
                }
            }
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.random == true)
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    WMP.Ctlcontrols.currentPosition = rnd.Next(0, (int)WMP.currentMedia.duration / 2);
        }

        private void WMP_Enter(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            sp.Play();
            this.Close();
            Victorina.ReadParam();
            p.cbAllDiry.Checked = Victorina.allDirestry;
            p.cbGame.Text = Victorina.gameDuraction.ToString();
            p.cbMusic.Text = Victorina.musicDusraction.ToString();
            p.cbRandom.Checked = Victorina.random;
            Victorina.ReadMusic();
            oT1.Text = Convert.ToString(0);
            oT2.Text = Convert.ToString(0);
        }

         void over ()
            {
            }

        private void oT2_Click(object sender, EventArgs e)
        {

        }
    }
}
