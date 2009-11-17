using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Orders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
        }

        void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource("OrderDetailsDataSet_OrderDetails", OrderDetailsDataSet.Tables[0]));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrdersDataSet.ReadXml("Orders.xml");
            this.OrderDetailsDataSet.ReadXml("OrderDetails.xml");
            this.reportViewer1.RefreshReport();
        }
    }
}