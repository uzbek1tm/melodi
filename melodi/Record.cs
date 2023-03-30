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
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Record_Load(object sender, EventArgs e)
        {
            int s = Victorina.Winercount;
            Victorina.ReadParam2();
            label2.Text = Convert.ToString(Victorina.Winercount);
            label1.Text = Victorina.PlayerWiner;
            switch (Victorina.Winercount)
            {
                case 1:
                    label3.Text = "Балл";
                    break;
                case 2:
                    label3.Text = "Балла";
                    break;
                case 3:
                    label3.Text = "Балла";
                    break;
                case 4:
                    label3.Text = "Балла";
                    break;
                default:

                    label3.Text = "Баллов";
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

