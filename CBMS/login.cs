﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace City_bus_mgmt_system
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            Main mn = new Main();
            mn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userlogin usl = new userlogin();
            usl.Show();
            this.Hide();
        }
    }
}
