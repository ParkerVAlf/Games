
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
            SuspendLayout();
            // 
            // memoryBttn
            // 
            memoryBttn.BackColor = System.Drawing.Color.FromArgb(0, 197, 200);
            memoryBttn.BackgroundImage = Properties.Resources.ButtonBlue;
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
            yahtzeeBttn.BackgroundImage = Properties.Resources.ButtonBlue;
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
            blackjackBttn.BackgroundImage = Properties.Resources.ButtonBlue;
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
            quitBttn.BackgroundImage = Properties.Resources.Color_Gradient;
            quitBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(70, 231, 209);
            quitBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            quitBttn.Location = new System.Drawing.Point(14, 483);
            quitBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            quitBttn.Name = "quitBttn";
            quitBttn.Size = new System.Drawing.Size(421, 73);
            quitBttn.TabIndex = 3;
            quitBttn.Text = "Quit";
            quitBttn.UseVisualStyleBackColor = false;
            quitBttn.Click += quitBttn_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(6, 25, 29);
            ClientSize = new System.Drawing.Size(448, 600);
            Controls.Add(quitBttn);
            Controls.Add(blackjackBttn);
            Controls.Add(yahtzeeBttn);
            Controls.Add(memoryBttn);
            ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button memoryBttn;
        private System.Windows.Forms.Button yahtzeeBttn;
        private System.Windows.Forms.Button blackjackBttn;
        private System.Windows.Forms.Button quitBttn;
    }
}

