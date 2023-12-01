using Games;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;


namespace Games
{
    public partial class Breakout : Form
    {
        
        public Breakout()
        {
            InitializeComponent();
        }

        private void Breakout_Load(object sender,EventArgs e)
        {

        }

        // Check if user has entered esc. If so, quit the application
        private void Breakout_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = (Keys)sender;
            if (e.KeyCode == Keys.Left)
            {
                label1.Text += "weiner";
                this.Hide();
                Menu menuForm = new Menu();
                menuForm.ShowDialog();
                this.Close();
                // prevent child controls from handling this event as well
                //e.SuppressKeyPress = true;
            }
        }
    }
}
