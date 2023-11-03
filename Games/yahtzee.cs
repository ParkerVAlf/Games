using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Games
{
    public partial class yahtzee : Form
    {
        public yahtzee()
        {
            InitializeComponent();
        }

        private void yahtzee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu();
            menuForm.ShowDialog();
        }
    }
}
