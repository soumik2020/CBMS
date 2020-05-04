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
    public partial class ticketing : Form
    {
        public ticketing()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ticketing_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select route_no from route_mgmt", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                comboBox3.Items.Add(rdr["route_no"]);
            }
            rdr.Close();
            rdr.Dispose();

            SqlCommand cmd1 = new SqlCommand("select bus_type from bus_details", con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {
                comboBox1.Items.Add(rdr1["bus_type"]).ToString();
            }
            rdr1.Close();
            rdr1.Dispose();

            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from route_mgmt where route_no='" + comboBox3.Text + "'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                comboBox4.Text = rdr["start"].ToString();
                comboBox5.Text = rdr["stop"].ToString();
            }
            rdr.Close();
            rdr.Dispose();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            //SqlCommand cmd = new SqlCommand("select * from bus_details where bus_no='" + comboBox2.Text + "'", con);
            //SqlDataReader rdr = cmd.ExecuteReader();
            //if (rdr.Read())
            //{
            //    textBox5.Text = rdr["child_fare"].ToString();
            //    textBox6.Text = rdr["adult_fare"].ToString();
            //}
            //rdr.Close();
            //rdr.Dispose();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox3.Visible = true;
                textBox5.Visible = true ;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked  == true)
            {
                textBox4.Visible = true;
                textBox6.Visible = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = (double.Parse(textBox3.Text) * double.Parse(textBox5.Text)).ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = (double.Parse(textBox4.Text) * double.Parse(textBox6.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox9.Text = (double.Parse(textBox8.Text) + double.Parse(textBox7.Text)).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from bus_details where bus_type='" + comboBox1.Text + "'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                comboBox2.Text = rdr["bus_no"].ToString();
            }
            rdr.Close();
            rdr.Dispose();

            SqlCommand cmd1 = new SqlCommand("select * from bus_details where bus_type='" + comboBox1.Text + "'", con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            if (rdr1.Read())
            {
                textBox5.Text = rdr1["child_fare"].ToString();
                textBox6.Text = rdr1["adult_fare"].ToString();
            }
            rdr1.Close();
            rdr1.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            print pr = new print();
            pr.textBox1.Text = comboBox1.Text;
            pr.textBox2.Text = comboBox2.Text;
            pr.textBox3.Text = comboBox3.Text;
            pr.textBox4.Text = comboBox4.Text;
            pr.textBox5.Text = comboBox5.Text;
            pr.textBox7.Text = textBox7.Text;
            pr.textBox8.Text = textBox8.Text;
            pr.textBox9.Text = textBox9.Text;
            pr.Show();
            this.Hide();

        }
    }
}
