using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace City_bus_mgmt_system
{
    public partial class userlogin : Form
    {
        public userlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ticketing tkt = new ticketing();
            tkt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
