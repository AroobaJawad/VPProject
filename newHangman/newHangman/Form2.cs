using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace newHangman
{
    public partial class Hangmanfm : Form
    {

        private Image[] hangImage = { Properties.Resources.h1, Properties.Resources.h2,
                                    Properties.Resources.h3,Properties.Resources.h4,
                                    Properties.Resources.h5,Properties.Resources.h6};

        private int incorrectGuess = 0;
        private string[] words;
        private string current = "";
        private string copyCurrent = "";

        public Hangmanfm()
        {
            InitializeComponent();
        }

        private void Hangmanfm_Load(object sender, EventArgs e)
        {
            PicBoxBee.Visible = true;
            listwords();
            getWord();
        }

        private void listwords()    //method for reading txt file of random words
        {

            string[] readText = File.ReadAllLines("hangman File.txt");  //reads all lines in the file
            words = new string[readText.Length];   // tells how many items are in the list
            int index = 0;
            foreach (string s in readText)
            {
                words[index++] = s.ToString();    //visit whole list of items and store them to words
            }


        }

        private void getWord()            // gets random word from the list
        {
            incorrectGuess = 0;
            hangmanImage.Image = hangImage[incorrectGuess];    //increases hang image at every wrong guess
            int getIndex = (new Random()).Next(words.Length);  // generate random number from list of words between word at 0 index to maximum
            current = words[getIndex];
            //MessageBox.Show("" + current + " " + current.Length);
            copyCurrent = "";

            for (int index = 0; index < current.Length; index++)    // generate _ equal to original word. 
            {
                copyCurrent += "_";
            }
            displayCopy();


        }

        private void displayCopy()                //Display _ in place of orignal word
        {
            lblViewWords.Text = "";
            for (int index = 0; index < copyCurrent.Length; index++)
            {
                lblViewWords.Text += copyCurrent.Substring(index, 1);   //start index and length. copy 1 at a time
                lblViewWords.Text += " ";
            }
        }

        private void returnlbl_Click(object sender, EventArgs e)
        {
            main_form obj = new main_form();
            obj.Show();
            this.Hide();
        }

        private void hint()
        {
            char first = current.ToCharArray()[0];
            char last = current[current.Length - 1];
            lblshow.Text = "First Letter : " + first + "  Last Letter : " + last;
        }

        private void btnA_Click(object sender, EventArgs e)  // replace _ with original letter
        {
            Button choice = sender as Button;

            choice.Enabled = false;
            choice.Text = choice.Text.ToLower();
            if (current.Contains(choice.Text))
            {
                char[] temp = copyCurrent.ToCharArray();
                char[] find = current.ToCharArray();
                char guessChar = choice.Text.ElementAt(0);
                for (int index = 0; index < find.Length; index++)
                {
                    if (find[index] == guessChar)
                    {
                        temp[index] = guessChar;
                    }
                }
                copyCurrent = new string(temp);
                displayCopy();
            }
            else
            {
                incorrectGuess++;      //change the images on every letter wrong guessed.
            }
            if (incorrectGuess < 6)
            {
                hangmanImage.Image = hangImage[incorrectGuess];
            }
            else
            {
                this.Hide();
                myDialogue md = new myDialogue(current, "Lose");
                md.Show();
            }
            if (copyCurrent.Equals(current))
            {
                this.Hide();
                myDialogue md = new myDialogue(current, "Win");
                md.Show();
            }
        }

        private void lblhint_Click(object sender, EventArgs e)
        {
            hint();
            lblhint.Visible = false;   
        }

       
    }
}
