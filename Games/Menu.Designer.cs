
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
            this.memoryBttn = new System.Windows.Forms.Button();
            this.yahtzeeBttn = new System.Windows.Forms.Button();
            this.blackjackBttn = new System.Windows.Forms.Button();
            this.quitBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memoryBttn
            // 
            this.memoryBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.memoryBttn.BackgroundImage = global::Games.Properties.Resources.GameButtonBlue;
            this.memoryBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(231)))), ((int)(((byte)(209)))));
            this.memoryBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.memoryBttn.Location = new System.Drawing.Point(12, 27);
            this.memoryBttn.Name = "memoryBttn";
            this.memoryBttn.Size = new System.Drawing.Size(111, 55);
            this.memoryBttn.TabIndex = 0;
            this.memoryBttn.Text = "Memory";
            this.memoryBttn.UseVisualStyleBackColor = false;
            this.memoryBttn.Click += new System.EventHandler(this.memoryBttn_Click);
            // 
            // yahtzeeBttn
            // 
            this.yahtzeeBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.yahtzeeBttn.BackgroundImage = global::Games.Properties.Resources.GameButtonBlue;
            this.yahtzeeBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(231)))), ((int)(((byte)(209)))));
            this.yahtzeeBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yahtzeeBttn.Location = new System.Drawing.Point(140, 27);
            this.yahtzeeBttn.Name = "yahtzeeBttn";
            this.yahtzeeBttn.Size = new System.Drawing.Size(111, 55);
            this.yahtzeeBttn.TabIndex = 1;
            this.yahtzeeBttn.Text = "Yahtzee";
            this.yahtzeeBttn.UseVisualStyleBackColor = false;
            this.yahtzeeBttn.Click += new System.EventHandler(this.yahtzeeBttn_Click);
            // 
            // blackjackBttn
            // 
            this.blackjackBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.blackjackBttn.BackgroundImage = global::Games.Properties.Resources.GameButtonBlue;
            this.blackjackBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(231)))), ((int)(((byte)(209)))));
            this.blackjackBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.blackjackBttn.Location = new System.Drawing.Point(269, 27);
            this.blackjackBttn.Name = "blackjackBttn";
            this.blackjackBttn.Size = new System.Drawing.Size(111, 55);
            this.blackjackBttn.TabIndex = 2;
            this.blackjackBttn.Text = "Blackjack";
            this.blackjackBttn.UseVisualStyleBackColor = false;
            this.blackjackBttn.Click += new System.EventHandler(this.blackjackBttn_Click);
            // 
            // quitBttn
            // 
            this.quitBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.quitBttn.BackgroundImage = global::Games.Properties.Resources.QuitButtonBlue;
            this.quitBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(231)))), ((int)(((byte)(209)))));
            this.quitBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quitBttn.Location = new System.Drawing.Point(12, 369);
            this.quitBttn.Name = "quitBttn";
            this.quitBttn.Size = new System.Drawing.Size(368, 55);
            this.quitBttn.TabIndex = 3;
            this.quitBttn.Text = "Quit";
            this.quitBttn.UseVisualStyleBackColor = false;
            this.quitBttn.Click += new System.EventHandler(this.quitBttn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.quitBttn);
            this.Controls.Add(this.blackjackBttn);
            this.Controls.Add(this.yahtzeeBttn);
            this.Controls.Add(this.memoryBttn);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button memoryBttn;
        private System.Windows.Forms.Button yahtzeeBttn;
        private System.Windows.Forms.Button blackjackBttn;
        private System.Windows.Forms.Button quitBttn;
    }
}

