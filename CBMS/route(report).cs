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
    public partial class route_report_ : Form
    {
        public route_report_()
        {
            InitializeComponent();
        }

        private void route_report__Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'city_bus_mgmtDataSet1.route_mgmt' table. You can move, or remove it, as needed.
            this.route_mgmtTableAdapter.Fill(this.city_bus_mgmtDataSet1.route_mgmt);

            this.reportViewer1.RefreshReport();
        }
    }
}
