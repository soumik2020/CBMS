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
    public partial class rute_mgmt_edit_ : Form
    {
        public rute_mgmt_edit_()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from route_mgmt where route_no='" + comboBox1.Text + "'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read()) 
            {
                textBox2.Text = rdr["no_of_stops"].ToString();
                textBox3.Text = rdr["fare_stages"].ToString();
                textBox4.Text = rdr["start"].ToString();
                textBox5.Text = rdr["stop"].ToString();
                textBox6.Text = rdr["start_time"].ToString();
                textBox7.Text = rdr["end_time"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("update route_mgmt set route_no='" + comboBox1.Text + "',no_of_stops='" + textBox2.Text + "',fare_stages='" + textBox3.Text + "',start='" + textBox4.Text + "',stop='" + textBox5.Text + "',start_time='" + textBox6.Text + "',end_time='" + textBox7.Text + "' where route_no='"+comboBox1.Text+"'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Edited Successfully");
            comboBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            comboBox1.Focus();
        }

        private void rute_mgmt_edit__Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select route_no from route_mgmt", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                comboBox1.Items.Add(rdr["route_no"]);
            }
            rdr.Close();
            rdr.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
