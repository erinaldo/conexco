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
    public partial class FrmFacturaBImprimir : Form
    {
        public int IdFactura { get; set; }

        public FrmFacturaBImprimir()
        {
            InitializeComponent();
        }

        private void FrmFacturaBImprimir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ConexcoImpresionDataSet.FacturaImpresion' table. You can move, or remove it, as needed.
            this.FacturaImpresionTableAdapter.Fill(this.ConexcoImpresionDataSet.FacturaImpresion, IdFactura);
            // TODO: This line of code loads data into the 'ConexcoImpresionDataSet.FacturaLineaImpresion' table. You can move, or remove it, as needed.
            this.FacturaLineaImpresionTableAdapter.Fill(this.ConexcoImpresionDataSet.FacturaLineaImpresion, IdFactura);
            // TODO: This line of code loads data into the 'ConexcoImpresionDataSet.FacturaBLineaImpresion' table. You can move, or remove it, as needed.
            this.FacturaBLineaImpresionTableAdapter.Fill(this.ConexcoImpresionDataSet.FacturaBLineaImpresion, IdFactura);

            reportViewerFacturaB.RefreshReport();

        }
    }
}
