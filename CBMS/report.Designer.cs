namespace City_bus_mgmt_system
{
    partial class report
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
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.city_bus_mgmtDataSet = new City_bus_mgmt_system.city_bus_mgmtDataSet();
            this.emp_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emp_detailsTableAdapter = new City_bus_mgmt_system.city_bus_mgmtDataSetTableAdapters.emp_detailsTableAdapter();
            this.accountTableAdapter = new City_bus_mgmt_system.city_bus_mgmtDataSetTableAdapters.accountTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.city_bus_mgmtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_detailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "city_bus_mgmtDataSet_account";
            reportDataSource1.Value = this.accountBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "City_bus_mgmt_system.ACCOUNT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(841, 427);
            this.reportViewer1.TabIndex = 2;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "account";
            this.accountBindingSource.DataSource = this.city_bus_mgmtDataSet;
            // 
            // city_bus_mgmtDataSet
            // 
            this.city_bus_mgmtDataSet.DataSetName = "city_bus_mgmtDataSet";
            this.city_bus_mgmtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emp_detailsBindingSource
            // 
            this.emp_detailsBindingSource.DataMember = "emp_details";
            this.emp_detailsBindingSource.DataSource = this.city_bus_mgmtDataSet;
            // 
            // emp_detailsTableAdapter
            // 
            this.emp_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 432);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report";
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.city_bus_mgmtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_detailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource emp_detailsBindingSource;
        private city_bus_mgmtDataSet city_bus_mgmtDataSet;
        private City_bus_mgmt_system.city_bus_mgmtDataSetTableAdapters.emp_detailsTableAdapter emp_detailsTableAdapter;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private City_bus_mgmt_system.city_bus_mgmtDataSetTableAdapters.accountTableAdapter accountTableAdapter;
    }
}