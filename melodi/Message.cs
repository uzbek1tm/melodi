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
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
        }

        private void lbplayer_Click(object sender, EventArgs e)
        {

        }

        private void lbAnswer_Click(object sender, EventArgs e)
        {
            lbAnswer.Text = Victorina.answer;
        }
    }
}
