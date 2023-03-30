using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace melodi
{
    public partial class fParam : Form
    {
        public fParam()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Victorina.allDirestry = cbAllDiry.Checked;
            Victorina.gameDuraction = Convert.ToInt32(cbGame.Text);
            Victorina.musicDusraction = Convert.ToInt32(cbMusic.Text);
            Victorina.random = cbRandom.Checked;
         
            Victorina.WriteParam();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            Set();

            this.Hide();
        }
        void Set()
        {
            Victorina.ReadParam();
            cbAllDiry.Checked = Victorina.allDirestry;
            cbGame.Text = Victorina.gameDuraction.ToString();
            cbMusic.Text = Victorina.musicDusraction.ToString();
            cbRandom.Checked = Victorina.random;
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                string[] music_list = Directory.GetFiles(fbd.SelectedPath,"*.mp3", cbAllDiry.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                Victorina.LastFolder = fbd.SelectedPath;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(music_list);
                Victorina.list.Clear();
                Victorina.list.AddRange(music_list);
            }
        }

        private void fParam_Load(object sender, EventArgs e)
        {
            Set();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Victorina.list.ToArray());
        }
    }
}
