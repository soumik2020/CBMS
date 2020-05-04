using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace City_bus_mgmt_system
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

     

        private void report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'city_bus_mgmtDataSet.account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.city_bus_mgmtDataSet.account);
            // TODO: This line of code loads data into the 'city_bus_mgmtDataSet.emp_details' table. You can move, or remove it, as needed.
            this.emp_detailsTableAdapter.Fill(this.city_bus_mgmtDataSet.emp_details);

            this.reportViewer1.RefreshReport();
        }
    }
}
