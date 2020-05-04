namespace City_bus_mgmt_system
{
    partial class route_report_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.city_bus_mgmtDataSet1 = new City_bus_mgmt_system.city_bus_mgmtDataSet1();
            this.route_mgmtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.route_mgmtTableAdapter = new City_bus_mgmt_system.city_bus_mgmtDataSet1TableAdapters.route_mgmtTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.city_bus_mgmtDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.route_mgmtBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "city_bus_mgmtDataSet1_route_mgmt";
            reportDataSource1.Value = this.route_mgmtBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "City_bus_mgmt_system.ROUTE MANAGEMENT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 9);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(830, 504);
            this.reportViewer1.TabIndex = 0;
            // 
            // city_bus_mgmtDataSet1
            // 
            this.city_bus_mgmtDataSet1.DataSetName = "city_bus_mgmtDataSet1";
            this.city_bus_mgmtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // route_mgmtBindingSource
            // 
            this.route_mgmtBindingSource.DataMember = "route_mgmt";
            this.route_mgmtBindingSource.DataSource = this.city_bus_mgmtDataSet1;
            // 
            // route_mgmtTableAdapter
            // 
            this.route_mgmtTableAdapter.ClearBeforeFill = true;
            // 
            // route_report_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 519);
            this.Controls.Add(this.reportViewer1);
            this.Name = "route_report_";
            this.Text = "route_report_";
            this.Load += new System.EventHandler(this.route_report__Load);
            ((System.ComponentModel.ISupportInitialize)(this.city_bus_mgmtDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.route_mgmtBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource route_mgmtBindingSource;
        private city_bus_mgmtDataSet1 city_bus_mgmtDataSet1;
        private City_bus_mgmt_system.city_bus_mgmtDataSet1TableAdapters.route_mgmtTableAdapter route_mgmtTableAdapter;
    }
}