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
    public partial class route_mgmt_add_ : Form
    {
        public route_mgmt_add_()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=city_bus_mgmt;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into route_mgmt(route_no,no_of_stops,fare_stages,start,stop,start_time,end_time) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Added Successfully");
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox1.Focus();

            con.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
