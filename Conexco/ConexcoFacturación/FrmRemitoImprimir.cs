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
    public partial class FrmRemitoImprimir : Form
    {
        public int IdRemito { get; set; }

        public FrmRemitoImprimir()
        {
            InitializeComponent();
        }

        private void FrmRemitoImprimir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ConexcoImpresionDataSet.RemitoImpresion' table. You can move, or remove it, as needed.
            this.RemitoImpresionTableAdapter.Fill(this.ConexcoImpresionDataSet.RemitoImpresion, IdRemito);
            // TODO: This line of code loads data into the 'ConexcoImpresionDataSet.RemitoLineaImpresion' table. You can move, or remove it, as needed.
            this.RemitoLineaImpresionTableAdapter.Fill(this.ConexcoImpresionDataSet.RemitoLineaImpresion, IdRemito);

            reportViewerRemito.RefreshReport();
        }
    }
}
