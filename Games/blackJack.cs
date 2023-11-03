using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Games
{
    public partial class blackJack : Form
    {
        public blackJack()
        {
            InitializeComponent();
        }

        private void blackJack_Load(object sender, EventArgs e)
        {

        }

        // Quit button
        private void quitBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu();
            menuForm.ShowDialog();
            this.Close();
        }
    }
}
