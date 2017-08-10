using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace ReportingViewer.FormsReportViewers
{
    public partial class FormParamsViewer : Form
    {
        public FormParamsViewer()
        {
            InitializeComponent();
        }

        private void FormParamsViewer_Load(object sender, EventArgs e)
        {
            DataTable dt = this.generate_report(DateTime.Parse("2013-01-01"), DateTime.Parse("2013-01-03"));
            this.getOrdersParamReportBindingSource.DataSource = dt;
            
            ReportParameter[] pars = new ReportParameter[]
            {
                new ReportParameter("fromDate", "2013-01-01"),
                new ReportParameter("toDate", "2013-01-03")
            };
            this.reportViewer1.LocalReport.SetParameters(pars);

            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private DataTable generate_report(DateTime from, DateTime to)
        {
            DataTable dt = new DataTable("Params");
            string conStr = ConfigurationManager.ConnectionStrings["ReportingViewer.Properties.Settings.WideWorldImporters"].ConnectionString;
            using (SqlConnection sqlcon = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("GetOrdersParamReport", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@From", SqlDbType.Date).Value = from.Date;
                cmd.Parameters.Add("@To", SqlDbType.Date).Value = to.Date;

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            }

            return dt;
        }
    }
}
