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

            buttonsPressed = 0;
            squares = new Button[10, 10];
            values = new int[10, 10];

            //Generating buttons
            this.Shown += CreateButtonDelegate;
        }

        private void Minesweeper_Load(object sender, EventArgs e)
        {
            
        }

        // Called to generate and place buttons
        private void CreateButtonDelegate(object sender, EventArgs e)
        {

            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 1; col++)
                {
                    squares[row, col] = new Button();
                    this.Controls.Add(squares[row, col]);
                    //squares[row, col] += new System.EventHandler(this.mineSquare_MouseDown);
                    squares[row, col].Text = "";
                    squares[row, col].Size = new Size(25, 25);
                    squares[row, col].Location = new Point(50 + (23 * row), 50);

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
