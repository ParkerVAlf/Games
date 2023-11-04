using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


// WARNING: I fucked up row and column, so in all my code just understand that 
// row = X, and col = Y. sorry /:
namespace Games
{
    public partial class Minesweeper : Form
    {
        int buttonsPressed; // Tracks how many squares you've cleared
        Button[,] squares;  // Stores buttons
        int[,] values;      // Stores each square score, -1 represents a mine
        public const int MINES = 40;

        public Minesweeper()
        {
            InitializeComponent();
        }

        private void Minesweeper_Load(object sender, EventArgs e)
        {
            buttonsPressed = 0;
            squares = new Button[16, 16];
            values = new int[16, 16];

            // Storing all buttons in squares array
            for (int row = 0; row < 16; row++)
            {
                for (int col = 0; col < 16; col++)
                {
                    // Getting numbers as strings and properly adding "0" where needed
                    string r;
                    string c;
                    if (row < 10)
                    {
                        r = "0";
                        r += row.ToString();
                    }
                    else
                        r = row.ToString();
                    if (col < 10)
                    {
                        c = "0";
                        c += col.ToString();
                    }
                    else
                        c = col.ToString();


                    squares[row, col] = (Button)this.Controls["bttn" + r + c];
                }
            }

            // Placing mines (represented in values[,] as a -1)
            Random rnd = new Random();
            int x, y;
            for (int i = 0; i < MINES; i++)
            {
                while (true)
                {
                    x = rnd.Next(16);
                    y = rnd.Next(16);
                    if (values[x,y] != -1)
                    {
                        values[x, y] = -1;
                        break;
                    }
                }
            }

            // Calculating nearby mines
            for (int row = 0; row < 16; row++)
            {
                for (int col = 0; col < 16; col++)
                {
                    int tracker = 0;    // Tracking nearby mine count
                    int subX = row - 1, subY = col - 1, addX = row + 1, addY = col + 1;

                    // Vertical/Horizontal checks
                    if (subX >= 0)
                        if (values[subX, col] == -1)
                            tracker++;
                    if (subY >= 0)
                        if (values[row, subY] == -1)
                            tracker++;
                    if (addX >= 0)
                        if (values[addX, col] == -1)
                            tracker++;
                    if (addY >= 0)
                        if (values[row, addY] == -1)
                            tracker++;

                    // Diagonal checks
                    if (subX >= 0 && subY >= 0)
                        if (values[row, addY] == -1)
                            tracker++;
                }
            }
        }



        // Logic of game
        private void mineSquare_MouseDown(object sender, MouseEventArgs e)
        {
            // Getting button position from name
            Button b = (Button)sender;
            string name = b.Name;
            int x = 0, y = 0;
            if (name[4] == '1')
            {
                x = 10;
            }
            x += name[5] - '0';

            if (name[6] == '1')
            {
                y = 10;
            }
            y += name[7] - '0';

            // Left click logic
            if (e.Button == MouseButtons.Left)
            {
                testLbl.Text = x.ToString() + ", " + y.ToString() + " Left";
            }
            // Right click logic
            else if (e.Button == MouseButtons.Right)
            {
                testLbl.Text = x.ToString() + ", " + y.ToString() + " Right";
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
