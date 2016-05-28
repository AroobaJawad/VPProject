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
    public partial class myDialogue : Form
    {
        string status = "";
        string word = "";

        public myDialogue(string Word, string Status)
        {
            InitializeComponent();
            status = Status;
            word = Word;
        }

        private void myDialogue_Load(object sender, EventArgs e)
        {

            if (status == "Win")
            {
               pictureBox1.ImageLocation = @"C:\Users\Home\Documents\Visual Studio 2010\Projects\newHangman\newHangman\bin\Debug\1.gif";
            }
            else
                if (status == "Lose")
                {
                    labelLose.Visible = true;
                    labelWord.Text = "Actual word : " + word;
                    pictureBox1.ImageLocation = @"C:\Users\Home\Documents\Visual Studio 2010\Projects\newHangman\newHangman\bin\Debug\2.gif";
                }
        }

        private void labelRestart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hangmanfm obj = new Hangmanfm();
            obj.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        
    }
}
