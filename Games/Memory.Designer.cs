
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
            SuspendLayout();
            // 
            // quitBttn
            // 
            quitBttn.Location = new System.Drawing.Point(128, 331);
            quitBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            quitBttn.Name = "quitBttn";
            quitBttn.Size = new System.Drawing.Size(82, 22);
            quitBttn.TabIndex = 0;
            quitBttn.Text = "Quit";
            quitBttn.UseVisualStyleBackColor = true;
            quitBttn.Click += quitBttn_Click;
            // 
            // Memory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(388, 444);
            Controls.Add(quitBttn);
            Name = "Memory";
            Text = "Memory";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button quitBttn;
    }
}