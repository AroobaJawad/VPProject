namespace newHangman
{
    partial class myDialogue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLose = new System.Windows.Forms.Label();
            this.labelWord = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.labelRestart = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.Font = new System.Drawing.Font("Ravie", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelLose.Location = new System.Drawing.Point(128, 74);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(175, 34);
            this.labelLose.TabIndex = 1;
            this.labelLose.Text = "You lose!!";
            this.labelLose.Visible = false;
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelWord.Location = new System.Drawing.Point(141, 108);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(0, 18);
            this.labelWord.TabIndex = 2;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Mistral", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblExit.Location = new System.Drawing.Point(340, 270);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(49, 29);
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // labelRestart
            // 
            this.labelRestart.AutoSize = true;
            this.labelRestart.BackColor = System.Drawing.Color.Transparent;
            this.labelRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRestart.Font = new System.Drawing.Font("Mistral", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelRestart.Location = new System.Drawing.Point(12, 270);
            this.labelRestart.Name = "labelRestart";
            this.labelRestart.Size = new System.Drawing.Size(73, 29);
            this.labelRestart.TabIndex = 4;
            this.labelRestart.Text = "Restart";
            this.labelRestart.Click += new System.EventHandler(this.labelRestart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 251);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // myDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(401, 308);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.labelRestart);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "myDialogue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.Load += new System.EventHandler(this.myDialogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label labelRestart;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}