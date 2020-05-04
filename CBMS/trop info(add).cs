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
    public partial class trop_info_add_ : Form
    {
        public trop_info_add_()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void trop_info_add__Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select bus_no from bus_details", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                comboBox1.Items.Add(rdr["bus_no"]).ToString();
            }
            rdr.Close();
            rdr.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into trip_info(no_of_trips,route_no,bus_no,start_time,end_time,trip_amt) values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+textBox3.Text+"')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Added successfully");
            textBox5.Text = " ";
            textBox4.Text = " ";
                textBox2.Text=" ";
            textBox1.Text=" ";
            comboBox1.Text=" ";
            textBox3.Text = " ";
           textBox1.Focus();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
