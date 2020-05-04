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
    public partial class account : Form
    {
        public const int a = 100;
        public account()
        {
            InitializeComponent();
        }

        private void account_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select id from emp_details", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                comboBox1.Items.Add(rdr["id"]).ToString();
            }
            rdr.Close();
            rdr.Dispose();

            SqlCommand cmd1 = new SqlCommand("select bus_no from bus_details", con);
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {
                comboBox2.Items.Add(rdr1["bus_no"]).ToString();
            }
            rdr1.Close();
            rdr1.Dispose();

            SqlCommand cmd2 = new SqlCommand("select route_no from trip_info", con);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                comboBox3.Items.Add(rdr2["route_no"]).ToString();
            }
            rdr2.Close();
            rdr2.Dispose();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from emp_details where id='" + comboBox1.Text + "'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                textBox2.Text = rdr["f_name"].ToString();
                textBox3.Text = rdr["dl_no"].ToString();
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
                                   
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd=new SqlCommand("insert into account(emp_id,emp_name,dl_no,bus_no,date,route_no,trip_no,trip_amt,total)values('"+comboBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+comboBox2.Text+"','"+textBox5.Text+"','"+comboBox3.Text+"','"+textBox6.Text+"','"+textBox7.Text+"','"+textBox1.Text+"')",con);
            cmd.ExecuteNonQuery();
            textBox7.Text=" ";
            textBox6.Text=" ";
            textBox5.Text=" ";
            textBox3.Text=" ";
            textBox2.Text=" ";
            comboBox2.Text=" ";
                comboBox1.Text=" ";
            comboBox3.Text = " ";
            textBox1.Text = " ";
            comboBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd=new SqlCommand("select * from trip_info where route_no='"+comboBox3.Text+"'",con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                textBox7.Text = rdr["trip_amt"].ToString();
                textBox6.Text = rdr["no_of_trips"].ToString();
               
                

            }


        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = (double.Parse(textBox6.Text) * double.Parse(textBox7.Text)).ToString();
        }
    }
}
