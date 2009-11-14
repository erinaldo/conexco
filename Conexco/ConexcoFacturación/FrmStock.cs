using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Conexco.Controller;

namespace ConexcoFacturación
{
    public partial class FrmStock : Form
    {
        public StockController StockController { get; set; }
        public ArticulosController ArticulosController { get; set; }

        public FrmStock()
        {
            InitializeComponent();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            StockController = new StockController();

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            var idArticulo = grdArticulosStock.SelectedRows[0].Cells[0].Value;
            var resultado = new FrmIngreso() {IdArticulo = Convert.ToInt32(idArticulo)}.ShowDialog();
            if (resultado == DialogResult.OK)
                _ActualizarGrilla();
        }

        private void _ActualizarGrilla()
        {
            grdArticulosStock.DataSource = ArticulosController.ListarArticulos();
        }

        private void btnEgreso_Click(object sender, EventArgs e)
        {
            var idArticulo = grdArticulosStock.SelectedRows[0].Cells[0].Value;
            var resultado = new FrmEgreso() { IdArticulo = Convert.ToInt32(idArticulo) }.ShowDialog();
            if (resultado == DialogResult.OK)
                _ActualizarGrilla();
        }
    }
}
