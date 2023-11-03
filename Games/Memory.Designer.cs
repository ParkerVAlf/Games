
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
            quitBttn.Location = new System.Drawing.Point(186, 304);
            quitBttn.Name = "quitBttn";
            quitBttn.Size = new System.Drawing.Size(94, 29);
            quitBttn.TabIndex = 0;
            quitBttn.Text = "button1";
            quitBttn.UseVisualStyleBackColor = true;
            quitBttn.Click += quitBttn_Click;
            // 
            // Memory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(443, 592);
            Controls.Add(quitBttn);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Memory";
            Text = "Memory";
            Load += Memory_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button quitBttn;
    }
}