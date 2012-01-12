using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ConexcoFacturación
{
    public partial class FrmListadoStockImprimir : Form
    {
        public bool Descripcion { get; set; }

        public FrmListadoStockImprimir()
        {
            InitializeComponent();
        }

        private void FrmListadoStockImprimir_Load(object sender, EventArgs e)
        {
            ConexcoDataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'ConexcoDataSet.ListadoStockActual' table. You can move, or remove it, as needed.
            this.listadoStockActualTableAdapter.Fill(this.ConexcoDataSet.ListadoStockActual);

            if (this.Descripcion)
            {
                reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reportes\ListadoStockActualDesc.rdlc";
            }
            else
            {
                reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reportes\ListadoStockActual.rdlc";
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
