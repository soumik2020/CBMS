using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace City_bus_mgmt_system
{
    public partial class bus_stop_add_ : Form
    {
        public bus_stop_add_()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into bus_stops(route_no,stop_no,stop_name,fare_stage) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Added");
            textBox3.Text = " ";
            textBox2.Text = " ";
            textBox1.Text = " ";
            comboBox1.Text = " ";
            textBox1.Focus();

        }
    }
}
