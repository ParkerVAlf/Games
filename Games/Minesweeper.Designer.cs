
namespace Games
{
    partial class Minesweeper
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
            this.quitBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quitBttn
            // 
            this.quitBttn.Location = new System.Drawing.Point(544, 361);
            this.quitBttn.Name = "quitBttn";
            this.quitBttn.Size = new System.Drawing.Size(126, 49);
            this.quitBttn.TabIndex = 0;
            this.quitBttn.Text = "Quit";
            this.quitBttn.UseVisualStyleBackColor = true;
            this.quitBttn.Click += new System.EventHandler(this.quitBttn_Click);
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quitBttn);
            this.Name = "Minesweeper";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Minesweeper_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quitBttn;
    }
}