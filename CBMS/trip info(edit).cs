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
    public partial class trip_info_edit_ : Form
    {
        public trip_info_edit_()
        {
            InitializeComponent();
        }

        private void trip_info_edit__Load(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from trip_info where bus_no='" + comboBox1.Text + "'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                textBox2.Text = rdr["no_of_trips"].ToString();
                textBox3.Text = rdr["route_no"].ToString();
                textBox4.Text = rdr["start_time"].ToString();
                textBox5.Text = rdr["end_time"].ToString();
                textBox1.Text = rdr["trip_amt"].ToString();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("update trip_info set bus_no='" + comboBox1.Text + "',no_of_trips='" + textBox2.Text + "',route_no='" + textBox3.Text + "',start_time='" + textBox4.Text + "',end_time='" + textBox5.Text + "',trip_amt='"+textBox1.Text+"'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record edited");
            textBox5.Text = " ";
            textBox4.Text = " ";
            textBox3.Text = " ";
            textBox2.Text = " ";
            comboBox1.Text = " ";
            comboBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
