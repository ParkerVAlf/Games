﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Games
{
    public partial class Memory : Form
    {
        public Memory()
        {
            InitializeComponent();
        }

        private void Memory_Load(object sender, EventArgs e)
        {

        }

        // Closes form and reopens Menu
        private void quitBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu();
            menuForm.ShowDialog();
            this.Close();
        }

        private void Memory_Load_1(object sender, EventArgs e)
        {

        }
    }
}
