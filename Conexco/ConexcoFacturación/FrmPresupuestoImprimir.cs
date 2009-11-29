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
    public partial class FrmPresupuestoImprimir : Form
    {
        public int IdPresupuesto { get; set; }

        public FrmPresupuestoImprimir()
        {
            InitializeComponent();
        }

        private void FrmPresupuestoImprimir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ConexcoImpresionDataSet.PresupuestoImpresionCabecera' table. You can move, or remove it, as needed.
            this.PresupuestoImpresionCabeceraTableAdapter.Fill(this.ConexcoImpresionDataSet.PresupuestoImpresionCabecera);
            // TODO: This line of code loads data into the 'ConexcoImpresionDataSet.PresupuestoImpresion' table. You can move, or remove it, as needed.
            this.PresupuestoImpresionTableAdapter.Fill(this.ConexcoImpresionDataSet.PresupuestoImpresion, IdPresupuesto);
            // TODO: This line of code loads data into the 'ConexcoImpresionDataSet.PresupuestoLineaImpresion' table. You can move, or remove it, as needed.
            this.PresupuestoLineaImpresionTableAdapter.Fill(this.ConexcoImpresionDataSet.PresupuestoLineaImpresion, IdPresupuesto);

            reportViewerPresupuesto.LocalReport.ReportPath = Application.StartupPath + @"\Reportes\PresupuestoImpresion.rdlc";

            this.reportViewerPresupuesto.RefreshReport();
        }
    }
}
