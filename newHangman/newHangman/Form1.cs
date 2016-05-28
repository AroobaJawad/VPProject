using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace newHangman
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PicBoxHangManAni.Visible = true;

        }

        private void PicBoxHangManAni_Click(object sender, EventArgs e)
        {

        }

        private void playlbl_Click(object sender, EventArgs e)
        {
            Hangmanfm obj = new Hangmanfm();
            obj.Show();
            this.Hide();
        }

        private void exitlbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
