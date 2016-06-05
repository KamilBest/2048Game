namespace _2048
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.pressD = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bestScoreCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(194)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(226, -258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 248);
            this.label1.TabIndex = 8;
            this.label1.Text = "2048";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(194)))), ((int)(((byte)(46)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-41, -258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 248);
            this.label2.TabIndex = 9;
            this.label2.Text = "2048";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(194)))), ((int)(((byte)(46)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(492, -258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 248);
            this.label3.TabIndex = 10;
            this.label3.Text = "2048";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label6.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(164, -16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 731);
            this.label6.TabIndex = 20;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.play.ForeColor = System.Drawing.Color.White;
            this.play.Location = new System.Drawing.Point(225, 339);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(248, 44);
            this.play.TabIndex = 21;
            this.play.Text = "Play";
            this.play.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.play.Click += new System.EventHandler(this.play_Click_1);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.about.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.about.ForeColor = System.Drawing.Color.White;
            this.about.Location = new System.Drawing.Point(225, 448);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(248, 44);
            this.about.TabIndex = 23;
            this.about.Text = "About";
            this.about.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(225, 503);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(248, 44);
            this.exit.TabIndex = 24;
            this.exit.Text = "Exit";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pressD
            // 
            this.pressD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(194)))), ((int)(((byte)(46)))));
            this.pressD.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pressD.ForeColor = System.Drawing.Color.White;
            this.pressD.Location = new System.Drawing.Point(227, 63);
            this.pressD.Name = "pressD";
            this.pressD.Size = new System.Drawing.Size(248, 248);
            this.pressD.TabIndex = 25;
            this.pressD.Text = "2048";
            this.pressD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-12, 686);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(722, 44);
            this.label9.TabIndex = 26;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bestScoreCheck
            // 
            this.bestScoreCheck.AutoSize = true;
            this.bestScoreCheck.BackColor = System.Drawing.Color.Transparent;
            this.bestScoreCheck.Checked = true;
            this.bestScoreCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bestScoreCheck.ForeColor = System.Drawing.Color.White;
            this.bestScoreCheck.Location = new System.Drawing.Point(298, 402);
            this.bestScoreCheck.Name = "bestScoreCheck";
            this.bestScoreCheck.Size = new System.Drawing.Size(105, 17);
            this.bestScoreCheck.TabIndex = 27;
            this.bestScoreCheck.Text = "Load Best Score";
            this.bestScoreCheck.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(705, 707);
            this.Controls.Add(this.bestScoreCheck);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pressD);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.about);
            this.Controls.Add(this.play);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048 Game Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label play;
        private System.Windows.Forms.Label about;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label pressD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox bestScoreCheck;
    }
}