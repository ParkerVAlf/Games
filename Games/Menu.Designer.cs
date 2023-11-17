
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
            SuspendLayout();
            // 
            // memoryBttn
            // 
            memoryBttn.BackColor = System.Drawing.Color.FromArgb(0, 197, 200);
            memoryBttn.BackgroundImage = Properties.Resources.GameButtonBlue;
            memoryBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(70, 231, 209);
            memoryBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            memoryBttn.Location = new System.Drawing.Point(14, 36);
            memoryBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            memoryBttn.Name = "memoryBttn";
            memoryBttn.Size = new System.Drawing.Size(127, 73);
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
            yahtzeeBttn.Location = new System.Drawing.Point(160, 36);
            yahtzeeBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            yahtzeeBttn.Name = "yahtzeeBttn";
            yahtzeeBttn.Size = new System.Drawing.Size(127, 73);
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
            blackjackBttn.Location = new System.Drawing.Point(307, 36);
            blackjackBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            blackjackBttn.Name = "blackjackBttn";
            blackjackBttn.Size = new System.Drawing.Size(127, 73);
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
            quitBttn.Location = new System.Drawing.Point(14, 492);
            quitBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            quitBttn.Name = "quitBttn";
            quitBttn.Size = new System.Drawing.Size(421, 73);
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
            mineBttn.Location = new System.Drawing.Point(14, 131);
            mineBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            mineBttn.Name = "mineBttn";
            mineBttn.Size = new System.Drawing.Size(127, 73);
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
            snakeBttn.Location = new System.Drawing.Point(160, 131);
            snakeBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            snakeBttn.Name = "snakeBttn";
            snakeBttn.Size = new System.Drawing.Size(127, 73);
            snakeBttn.TabIndex = 5;
            snakeBttn.Text = "Snake";
            snakeBttn.UseVisualStyleBackColor = false;
            snakeBttn.Click += snakeBttn_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(6, 25, 29);
            ClientSize = new System.Drawing.Size(448, 600);
            Controls.Add(snakeBttn);
            Controls.Add(mineBttn);
            Controls.Add(quitBttn);
            Controls.Add(blackjackBttn);
            Controls.Add(yahtzeeBttn);
            Controls.Add(memoryBttn);
            ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}

