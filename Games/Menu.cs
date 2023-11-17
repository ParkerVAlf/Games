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
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        // Opens Memory game
        private void memoryBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Memory memForm = new Memory();
            memForm.ShowDialog();
            this.Close();
        }

        // Opens Yahtzee
        private void yahtzeeBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            yahtzee yahtzeeForm = new yahtzee();
            yahtzeeForm.ShowDialog();
            this.Close();
        }

        // Opens Blackjack
        private void blackjackBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            blackJack blackForm = new blackJack();
            blackForm.ShowDialog();
            this.Close();
        }

        // Opens Minesweeper
        private void mineBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Minesweeper mineForm = new Minesweeper();
            mineForm.ShowDialog();
            this.Close();
        }

        // Closes program
        private void quitBttn_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void snakeBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Snake snakeForm = new Snake();
            snakeForm.ShowDialog();
            this.Close();
        }
    }
}
