using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConexcoFacturación
{
    public partial class FrmListadoFacturasImprimir : Form
    {
        public int IdEstadoFacturas { get; set; }
        public int CantidadFacturas { get; set; }

        public FrmListadoFacturasImprimir()
        {
            InitializeComponent();
        }

        private void FrmListadoFacturasImprimir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ConexcoDataSet.ListadoFacturasLineaImpresion' table. You can move, or remove it, as needed.
            this.ListadoFacturasLineaImpresionTableAdapter.Fill(this.ConexcoDataSet.ListadoFacturasLineaImpresion,CantidadFacturas,IdEstadoFacturas);

            reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reportes\ListadoFacturasImpresion.rdlc";

            this.reportViewer1.RefreshReport();
        }
    }
}
