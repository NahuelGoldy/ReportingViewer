using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportingViewer.FormsReportViewers
{
    public partial class FormOrdersViewer : Form
    {
        public FormOrdersViewer()
        {
            InitializeComponent();
        }

        private void FormOrdersViewer_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ordersDataSet.Orders' Puede moverla o quitarla según sea necesario.
            this.ordersTableAdapter.Fill(this.ordersDataSet.Orders);

            this.reportViewer1.RefreshReport();
        }
    }
}
