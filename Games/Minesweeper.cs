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
        int buttonsPressed = 0;

        public Minesweeper()
        {
            InitializeComponent();
            this.Shown += CreateButtonDelegate;
        }

        private void Minesweeper_Load(object sender, EventArgs e)
        {
            /*for (int row = 0; row < 1; row++)
            {
                for (int col = 0; col < 1; col++)
                {
                    Button newButton = new Button();

                }
            }*/
        }
        private void CreateButtonDelegate(object sender, EventArgs e)
        {
            Button newButton = new Button();
            this.Controls.Add(newButton);
            newButton.Text = "";
            newButton.Location = new Point(70, 70);
            newButton.Size = new Size(25, 25);
            newButton.Location = new Point(20, 50);
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
