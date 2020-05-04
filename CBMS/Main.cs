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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route_mgmt_add_ rma = new route_mgmt_add_();
            rma.Show();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route_mgmt_del_ rmd = new route_mgmt_del_();
            rmd.Show();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rute_mgmt_edit_ rme = new rute_mgmt_edit_();
            rme.Show();

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bus_det_add_ bda = new bus_det_add_();
            bda.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bus_det_del_ bdd = new bus_det_del_();
            bdd.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bus_det_edit_ bde = new bus_det_edit_();
            bde.Show();
        }

        private void routeNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bus_stop_add_ bsa = new bus_stop_add_();
            bsa.Show();
        }

        private void stopNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bus_stop_del_ bsd = new bus_stop_del_();
            bsd.Show();
        }

        private void stopNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bus_stop_edit_ bse = new bus_stop_edit_();
            bse.Show();
        }

        private void saveToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            trop_info_add_ tia = new trop_info_add_();
            tia.Show();
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            trip_info_del_ til = new trip_info_del_();
            til.Show();

        }

        private void editToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            trip_info_edit_ tie = new trip_info_edit_();
            tie.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee_add_ ea = new employee_add_();
            ea.Show();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee_del_ ed = new employee_del_();
            ed.Show();

        }

        private void editEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee_edit_ ee = new employee_edit_();
            ee.Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            account ac = new account();
            ac.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report rpt = new report();
            rpt.Show();
        }

        private void routeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route_report_ rrp = new route_report_();
            rrp.Show();
        }

        private void tktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

      
    }
}
