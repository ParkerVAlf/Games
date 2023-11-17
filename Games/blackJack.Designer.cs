namespace Games
{
    partial class blackJack
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
            quitBttn = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            PlayerLbl = new System.Windows.Forms.Label();
            playBtn = new System.Windows.Forms.Button();
            hitBtn = new System.Windows.Forms.Button();
            standBtn = new System.Windows.Forms.Button();
            betUpDown = new System.Windows.Forms.NumericUpDown();
            moneyLbl = new System.Windows.Forms.Label();
            houseLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)betUpDown).BeginInit();
            SuspendLayout();
            // 
            // quitBttn
            // 
            quitBttn.Location = new System.Drawing.Point(786, 532);
            quitBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            quitBttn.Name = "quitBttn";
            quitBttn.Size = new System.Drawing.Size(86, 31);
            quitBttn.TabIndex = 0;
            quitBttn.Text = "quit";
            quitBttn.UseVisualStyleBackColor = true;
            quitBttn.Click += quitBttn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.Location = new System.Drawing.Point(52, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(125, 152);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.White;
            pictureBox2.Location = new System.Drawing.Point(241, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(125, 62);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.LightYellow;
            pictureBox3.Location = new System.Drawing.Point(74, 420);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(125, 62);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = System.Drawing.Color.Yellow;
            pictureBox4.Location = new System.Drawing.Point(241, 420);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(125, 62);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // PlayerLbl
            // 
            PlayerLbl.AutoSize = true;
            PlayerLbl.Location = new System.Drawing.Point(398, 439);
            PlayerLbl.Name = "PlayerLbl";
            PlayerLbl.Size = new System.Drawing.Size(50, 20);
            PlayerLbl.TabIndex = 5;
            PlayerLbl.Text = "label1";
            // 
            // playBtn
            // 
            playBtn.Location = new System.Drawing.Point(536, 387);
            playBtn.Name = "playBtn";
            playBtn.Size = new System.Drawing.Size(94, 29);
            playBtn.TabIndex = 6;
            playBtn.Text = "button1";
            playBtn.UseVisualStyleBackColor = true;
            playBtn.Click += playBtn_Click;
            // 
            // hitBtn
            // 
            hitBtn.Location = new System.Drawing.Point(536, 439);
            hitBtn.Name = "hitBtn";
            hitBtn.Size = new System.Drawing.Size(94, 29);
            hitBtn.TabIndex = 7;
            hitBtn.Text = "button2";
            hitBtn.UseVisualStyleBackColor = true;
            hitBtn.Click += hitBtn_Click;
            // 
            // standBtn
            // 
            standBtn.Location = new System.Drawing.Point(536, 495);
            standBtn.Name = "standBtn";
            standBtn.Size = new System.Drawing.Size(94, 29);
            standBtn.TabIndex = 8;
            standBtn.Text = "button3";
            standBtn.UseVisualStyleBackColor = true;
            standBtn.Click += standBtn_Click;
            // 
            // betUpDown
            // 
            betUpDown.Location = new System.Drawing.Point(655, 387);
            betUpDown.Name = "betUpDown";
            betUpDown.Size = new System.Drawing.Size(150, 27);
            betUpDown.TabIndex = 9;
            // 
            // moneyLbl
            // 
            moneyLbl.AutoSize = true;
            moneyLbl.Location = new System.Drawing.Point(667, 439);
            moneyLbl.Name = "moneyLbl";
            moneyLbl.Size = new System.Drawing.Size(50, 20);
            moneyLbl.TabIndex = 10;
            moneyLbl.Text = "label2";
            // 
            // houseLbl
            // 
            houseLbl.AutoSize = true;
            houseLbl.Location = new System.Drawing.Point(60, 202);
            houseLbl.Name = "houseLbl";
            houseLbl.Size = new System.Drawing.Size(50, 20);
            houseLbl.TabIndex = 11;
            houseLbl.Text = "label3";
            // 
            // blackJack
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.ForestGreen;
            ClientSize = new System.Drawing.Size(914, 600);
            Controls.Add(houseLbl);
            Controls.Add(moneyLbl);
            Controls.Add(betUpDown);
            Controls.Add(standBtn);
            Controls.Add(hitBtn);
            Controls.Add(playBtn);
            Controls.Add(PlayerLbl);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(quitBttn);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "blackJack";
            Text = "blackForm";
            Load += blackJack_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)betUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button quitBttn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label PlayerLbl;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button hitBtn;
        private System.Windows.Forms.Button standBtn;
        private System.Windows.Forms.NumericUpDown betUpDown;
        private System.Windows.Forms.Label moneyLbl;
        private System.Windows.Forms.Label houseLbl;
    }
}