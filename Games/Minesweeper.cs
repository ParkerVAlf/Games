using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Games
{
    public partial class Minesweeper : Form
    {
        int buttonsPressed; // Tracks how many squares you've cleared
        Button[,] squares;  // Stores buttons
        int[,] values;      // Stores each square score, -1 represents a mine

        public Minesweeper()
        {
            InitializeComponent();
        }

        private void Minesweeper_Load(object sender, EventArgs e)
        {
            buttonsPressed = 0;
            squares = new Button[16, 16];
            values = new int[16, 16];

            for (int row = 0; row < 16; row++)
            {
                for (int col = 0; col < 16; col++)
                {
                    string r;
                    string c;
                    squares[row, col] = (Button)this.Controls["bttn"];
                }
            }
        }


        private void mineSquare_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //do something
            }
            if (e.Button == MouseButtons.Right)
            {
                //do something
            }
        }

        private void quitBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu();
            menuForm.ShowDialog();
            this.Close();
        }

    }
}
