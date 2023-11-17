
namespace Games
{
    partial class Memory
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
            NewGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // quitBttn
            // 
            quitBttn.Location = new System.Drawing.Point(975, 11);
            quitBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            quitBttn.Name = "quitBttn";
            quitBttn.Size = new System.Drawing.Size(82, 22);
            quitBttn.TabIndex = 0;
            quitBttn.Text = "Quit";
            quitBttn.UseVisualStyleBackColor = true;
            quitBttn.Click += quitBttn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(100, 144);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // NewGameButton
            // 
            NewGameButton.Location = new System.Drawing.Point(894, 12);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new System.Drawing.Size(75, 23);
            NewGameButton.TabIndex = 2;
            NewGameButton.Text = "New Game";
            NewGameButton.UseVisualStyleBackColor = true;
            // 
            // Memory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkSeaGreen;
            ClientSize = new System.Drawing.Size(1069, 781);
            Controls.Add(NewGameButton);
            Controls.Add(pictureBox1);
            Controls.Add(quitBttn);
            Name = "Memory";
            Text = "Memory";
            Load += Memory_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button quitBttn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NewGameButton;
    }
}