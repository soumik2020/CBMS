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
    public partial class bus_det_edit_ : Form
    {
        public bus_det_edit_()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from bus_details where bus_no='" + comboBox2.Text + "'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                comboBox1. Text = rdr["bus_type"].ToString();
                textBox3.Text = rdr["min_charge"].ToString();
                textBox4.Text = rdr["depot"].ToString();
                textBox5.Text = rdr["fare_inc"].ToString();
                textBox6.Text = rdr["child_fare"].ToString();
                textBox7.Text = rdr["adult_fare"].ToString();
            }
            
        }

        private void bus_det_edit__Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select bus_no from bus_details", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                comboBox2.Items.Add(rdr["bus_no"]).ToString();
            }
            rdr.Close();
            rdr.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("update bus_details set bus_type='" + comboBox1.Text + "',bus_no='" + comboBox2.Text + "',min_charge='" + textBox3.Text + "',depot='" + textBox4.Text + "',fare_inc='" + textBox5.Text + "',child_fare='" + textBox6.Text + "',adult_fare='" + textBox7.Text + "' where bus_no='" + comboBox2.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Edited Successfully");
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            textBox7.Text = " ";
            textBox6.Text = " ";
            textBox5.Text = " ";
            textBox4.Text = " ";
            textBox3.Text = " ";
            comboBox2.Focus();

        }
    }
}
