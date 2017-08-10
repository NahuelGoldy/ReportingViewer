namespace ReportingViewer.FormsReportViewers
{
    partial class FormParamsViewer
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ordersParamsDataSet = new ReportingViewer.OrdersParamsDataSet();
            this.getOrdersParamReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getOrdersParamReportTableAdapter = new ReportingViewer.OrdersParamsDataSetTableAdapters.GetOrdersParamReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ordersParamsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrdersParamReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "Params";
            reportDataSource2.Value = this.getOrdersParamReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportingViewer.Reports.OrdersParamsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(284, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // ordersParamsDataSet
            // 
            this.ordersParamsDataSet.DataSetName = "OrdersParamsDataSet";
            this.ordersParamsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getOrdersParamReportBindingSource
            // 
            this.getOrdersParamReportBindingSource.DataMember = "GetOrdersParamReport";
            this.getOrdersParamReportBindingSource.DataSource = this.ordersParamsDataSet;
            // 
            // getOrdersParamReportTableAdapter
            // 
            this.getOrdersParamReportTableAdapter.ClearBeforeFill = true;
            // 
            // FormParamsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormParamsViewer";
            this.Text = "FormParamsViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormParamsViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersParamsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrdersParamReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getOrdersParamReportBindingSource;
        private OrdersParamsDataSet ordersParamsDataSet;
        private OrdersParamsDataSetTableAdapters.GetOrdersParamReportTableAdapter getOrdersParamReportTableAdapter;
    }
}