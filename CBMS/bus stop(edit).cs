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
    public partial class bus_stop_edit_ : Form
    {
        public bus_stop_edit_()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from bus_stops where route_no='" + comboBox1.Text + "'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                textBox2.Text = rdr["stop_no"].ToString();
                textBox3.Text = rdr["stop_name"].ToString();
                comboBox2. Text = rdr["fare_stage"].ToString();
            }
        }

        private void bus_stop_edit__Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select route_no from bus_stops", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                comboBox1.Items.Add(rdr["route_no"]).ToString();
            }
            rdr.Close();
            rdr.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("update bus_stops set route_no='" + comboBox1.Text + "',stop_no='" + textBox2.Text + "',stop_name='" + textBox3.Text + "',fare_stage='" + comboBox2.Text + "' where route_no='" + comboBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Edited");
            comboBox2.Text = " ";
            comboBox1.Text = " ";
            textBox3.Text = " ";
            textBox2.Text = " ";
            comboBox1.Focus();

        }
    }
}
