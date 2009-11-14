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
            ArticulosController = new ArticulosController();

            var listadoArticulos = ArticulosController.ListarArticulos();
            grdArticulosStock.DataSource = listadoArticulos;
            grdArticulosStock.Columns[0].Visible = false;
            grdArticulosStock.Columns[4].Visible = false;
            grdArticulosStock.Columns[5].Visible = false;
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

        private void OnArticuloSeleccionado(object sender, EventArgs e)
        {
            btnIngreso.Enabled = grdArticulosStock.SelectedRows.Count > 0;
            btnEgreso.Enabled = btnIngreso.Enabled;
        }
    }
}
