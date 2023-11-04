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
        bool gameOver;
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
            gameOver = false;
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

            // Properly generate everything
            testLbl.Text = "PENBIS";
            generateMines();
            testLbl.Text = "BOOBS";

        }

        private void generateMines()
        {
            // Placing mines (represented in values[,] as a -1)
            Random rnd = new Random();
            int x, y;
            for (int i = 0; i < MINES; i++)
            {
                while (true)
                {
                    x = rnd.Next(16);
                    y = rnd.Next(16);
                    if (values[x, y] != -1)
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
                    // Skipping mines
                    if (values[row, col] == -1)
                        continue;

                    int tracker = 0;    // Tracking nearby mine count
                    int subX = row - 1, subY = col - 1, addX = row + 1, addY = col + 1;

                    // Vertical/Horizontal checks
                    if (subX >= 0)
                        if (values[subX, col] == -1)
                            tracker++;
                    if (subY >= 0)
                        if (values[row, subY] == -1)
                            tracker++;
                    if (addX < 16)
                        if (values[addX, col] == -1)
                            tracker++;
                    if (addY < 16)
                        if (values[row, addY] == -1)
                            tracker++;

                    // Diagonal checks
                    if (subX >= 0 && subY >= 0)
                        if (values[subX, subY] == -1)
                            tracker++;
                    if (subX >= 0 && addY < 16)
                        if (values[subX, addY] == -1)
                            tracker++;
                    if (addX < 16 && subY >= 0)
                        if (values[addX, subY] == -1)
                            tracker++;
                    if (addX < 16 && addY < 16)
                        if (values[addX, addY] == -1)
                            tracker++;

                    // Setting value
                    values[row, col] = tracker;
                }
            }
        }


        private void displayNum(int x, int y)
        {
            if (values[x, y] != 0)
                squares[x,y].Text = values[x, y].ToString();
        }

        private int clearZeroes(int x, int y)
        {
            int count = 0;
            if (values[x, y] != 0 || squares[x, y].Enabled == false)
            {
                displayNum(x, y);
                return count;
            }

            count++;
            squares[x, y].Enabled = false;
            buttonsPressed++;

            if (x - 1 >= 0)
                count += clearZeroes(x - 1, y);
            if (x + 1 < 16)
                count += clearZeroes(x + 1, y);
            if (y - 1 >= 0)
                count += clearZeroes(x, y - 1);
            if (y + 1 < 16)
                count += clearZeroes(x, y + 1);

            return count;
        }

        private void resetBoard()
        {
            buttonsPressed = 0;
            gameOver = false;

            for (int x = 0; x < 16; x++)
            {
                for (int y = 0; y < 16; y++)
                {
                    squares[x, y].Enabled = true;
                    squares[x, y].Text = "";
                    values[x, y] = 0;
                }
            }
            generateMines();
        }

        // Logic of game
        private void mineSquare_MouseDown(object sender, MouseEventArgs e)
        {
            testLbl.Text = "mm";
            // Making sure game hasn't ended
            if (gameOver)
                return;

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
                testLbl.Text = "SHIT";
                //testLbl.Text = x.ToString() + ", " + y.ToString() + " Left

                // Making sure first move clears out a space at least 3 squares large.
                if (buttonsPressed == 0)
                {
                    while (true)
                    {
                        testLbl.Text ="BALLS";
                        if (values[x, y] != 0)
                        {
                            generateMines();
                            continue;
                        }
                        else if (clearZeroes(x, y) <= 2)
                        {
                            resetBoard();
                            continue;
                        }
                        else
                            break;
                    }
                }

                // Skipping marked clicks
                if (squares[x, y].Text == "!")
                    return;

                buttonsPressed++;
                displayNum(x, y);
                squares[x, y].Enabled = false;
            }
            // Right click logic
            else if (e.Button == MouseButtons.Right)
            {
                //testLbl.Text = x.ToString() + ", " + y.ToString() + " Right";
                if (squares[x, y].Text == "")
                {
                    squares[x, y].Text = "!";
                    squares[x, y].ForeColor = Color.Red;
                }
                else if (squares[x, y].Text == "!")
                {
                    squares[x, y].Text = "";
                    squares[x, y].ForeColor = Color.Black;
                }
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
