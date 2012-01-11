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
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void btnFacturasEmitidas_Click(object sender, EventArgs e)
        {
            var frmParameteres = new FrmListadoFacturasReportParameter();
            var result = frmParameteres.ShowDialog();

            if (result == DialogResult.OK)
            {
                new FrmListadoFacturasImprimir
                {
                    CantidadFacturas = frmParameteres.CantidadFacturas,
                    IdEstadoFacturas = frmParameteres.IdEstadoFacturas,
                    EstadoFacturas = frmParameteres.EstadoFacturas
                }.ShowDialog();
            }
            else
                return;
        }

        private void btnStockActual_Click(object sender, EventArgs e)
        {
            new FrmListadoStockImprimir
            {
                Descripcion = false
            }.ShowDialog();
        }

        private void btnStockActualDesc_Click(object sender, EventArgs e)
        {
            new FrmListadoStockImprimir
            {
                Descripcion = true
            }.ShowDialog();
        }
    }
}
