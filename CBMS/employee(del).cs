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
    public partial class employee_del_ : Form
    {
        public employee_del_()
        {
            InitializeComponent();
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
                textBox3.Text = rdr["l_name"].ToString();
                textBox4.Text = rdr["dob"].ToString();
                textBox5.Text = rdr["dl_no"].ToString();
                textBox6.Text = rdr["address"].ToString();
                textBox7.Text = rdr["phone"].ToString();
                textBox8.Text = rdr["city"].ToString();
                textBox9.Text = rdr["state"].ToString();
                textBox10.Text = rdr["pin_code"].ToString();
            }



        }

        private void employee_del__Load(object sender, EventArgs e)
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


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd=new SqlCommand("delete from emp_details where id='"+comboBox1.Text.Trim()+"'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Edited");
            comboBox1.Text = " ";
            textBox10.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = "";
            textBox8.Text = " ";
            textBox9.Text = " ";
            comboBox1.Focus();
        }
    }
}
