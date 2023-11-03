using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void quitBttn_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void memoryBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Memory memForm = new Memory();
            memForm.ShowDialog();
        }

        private void yahtzeeBttn_Click(object sender, EventArgs e)
        {

        }

        private void blackjackBttn_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
