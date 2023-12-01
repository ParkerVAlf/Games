
namespace Games
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            memoryBttn = new System.Windows.Forms.Button();
            yahtzeeBttn = new System.Windows.Forms.Button();
            blackjackBttn = new System.Windows.Forms.Button();
            quitBttn = new System.Windows.Forms.Button();
            mineBttn = new System.Windows.Forms.Button();
            snakeBttn = new System.Windows.Forms.Button();
            breakoutBttn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // memoryBttn
            // 
            memoryBttn.BackColor = System.Drawing.Color.FromArgb(0, 197, 200);
            memoryBttn.BackgroundImage = Properties.Resources.GameButtonBlue;
            memoryBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(70, 231, 209);
            memoryBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            memoryBttn.Location = new System.Drawing.Point(18, 45);
            memoryBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            memoryBttn.Name = "memoryBttn";
            memoryBttn.Size = new System.Drawing.Size(159, 91);
            memoryBttn.TabIndex = 0;
            memoryBttn.Text = "Memory";
            memoryBttn.UseVisualStyleBackColor = false;
            memoryBttn.Click += memoryBttn_Click;
            // 
            // yahtzeeBttn
            // 
            yahtzeeBttn.BackColor = System.Drawing.Color.FromArgb(0, 197, 200);
            yahtzeeBttn.BackgroundImage = Properties.Resources.GameButtonBlue;
            yahtzeeBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(70, 231, 209);
            yahtzeeBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            yahtzeeBttn.Location = new System.Drawing.Point(200, 45);
            yahtzeeBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            yahtzeeBttn.Name = "yahtzeeBttn";
            yahtzeeBttn.Size = new System.Drawing.Size(159, 91);
            yahtzeeBttn.TabIndex = 1;
            yahtzeeBttn.Text = "Yahtzee";
            yahtzeeBttn.UseVisualStyleBackColor = false;
            yahtzeeBttn.Click += yahtzeeBttn_Click;
            // 
            // blackjackBttn
            // 
            blackjackBttn.BackColor = System.Drawing.Color.FromArgb(0, 197, 200);
            blackjackBttn.BackgroundImage = Properties.Resources.GameButtonBlue;
            blackjackBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(70, 231, 209);
            blackjackBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            blackjackBttn.Location = new System.Drawing.Point(384, 45);
            blackjackBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            blackjackBttn.Name = "blackjackBttn";
            blackjackBttn.Size = new System.Drawing.Size(159, 91);
            blackjackBttn.TabIndex = 2;
            blackjackBttn.Text = "Blackjack";
            blackjackBttn.UseVisualStyleBackColor = false;
            blackjackBttn.Click += blackjackBttn_Click;
            // 
            // quitBttn
            // 
            quitBttn.BackColor = System.Drawing.Color.FromArgb(0, 197, 200);
            quitBttn.BackgroundImage = Properties.Resources.QuitButtonBlue;
            quitBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(70, 231, 209);
            quitBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            quitBttn.Location = new System.Drawing.Point(18, 615);
            quitBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            quitBttn.Name = "quitBttn";
            quitBttn.Size = new System.Drawing.Size(526, 91);
            quitBttn.TabIndex = 3;
            quitBttn.Text = "Quit";
            quitBttn.UseVisualStyleBackColor = false;
            quitBttn.Click += quitBttn_Click;
            // 
            // mineBttn
            // 
            mineBttn.BackColor = System.Drawing.Color.FromArgb(0, 197, 200);
            mineBttn.BackgroundImage = Properties.Resources.GameButtonBlue;
            mineBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(70, 231, 209);
            mineBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            mineBttn.Location = new System.Drawing.Point(18, 164);
            mineBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            mineBttn.Name = "mineBttn";
            mineBttn.Size = new System.Drawing.Size(159, 91);
            mineBttn.TabIndex = 4;
            mineBttn.Text = "Minesweeper";
            mineBttn.UseVisualStyleBackColor = false;
            mineBttn.Click += mineBttn_Click;
            // 
            // snakeBttn
            // 
            snakeBttn.BackColor = System.Drawing.Color.FromArgb(0, 197, 200);
            snakeBttn.BackgroundImage = Properties.Resources.GameButtonBlue;
            snakeBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(70, 231, 209);
            snakeBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            snakeBttn.Location = new System.Drawing.Point(200, 164);
            snakeBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            snakeBttn.Name = "snakeBttn";
            snakeBttn.Size = new System.Drawing.Size(159, 91);
            snakeBttn.TabIndex = 5;
            snakeBttn.Text = "Snake";
            snakeBttn.UseVisualStyleBackColor = false;
            snakeBttn.Click += snakeBttn_Click;
            // 
            // breakoutBttn
            // 
            breakoutBttn.BackColor = System.Drawing.Color.FromArgb(0, 197, 200);
            breakoutBttn.BackgroundImage = Properties.Resources.GameButtonBlue;
            breakoutBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(70, 231, 209);
            breakoutBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            breakoutBttn.Location = new System.Drawing.Point(384, 164);
            breakoutBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            breakoutBttn.Name = "breakoutBttn";
            breakoutBttn.Size = new System.Drawing.Size(159, 91);
            breakoutBttn.TabIndex = 6;
            breakoutBttn.Text = "Breakout";
            breakoutBttn.UseVisualStyleBackColor = false;
            breakoutBttn.Click += breakoutBttn_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(6, 25, 29);
            ClientSize = new System.Drawing.Size(560, 750);
            Controls.Add(breakoutBttn);
            Controls.Add(snakeBttn);
            Controls.Add(mineBttn);
            Controls.Add(quitBttn);
            Controls.Add(blackjackBttn);
            Controls.Add(yahtzeeBttn);
            Controls.Add(memoryBttn);
            ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button memoryBttn;
        private System.Windows.Forms.Button yahtzeeBttn;
        private System.Windows.Forms.Button blackjackBttn;
        private System.Windows.Forms.Button quitBttn;
        private System.Windows.Forms.Button mineBttn;
        private System.Windows.Forms.Button snakeBttn;
        private System.Windows.Forms.Button breakoutBttn;
    }
}

