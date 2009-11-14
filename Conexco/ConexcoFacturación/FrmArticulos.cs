using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Conexco.Controller;
using Conexco.Model;

namespace ConexcoFacturación
{
    public partial class FrmArticulos : Form
    {
        public ArticulosController articulosController { get; set; }

        public FrmArticulos()
        {
            InitializeComponent();
        }

        private void FrmArticulosStock_Load(object sender, EventArgs e)
        {
            articulosController = new ArticulosController();
            _ActualizarGrilla();
        }

        private void _ActualizarGrilla()
        {
            var listadoArticulos = articulosController.ListarArticulos();
            grdArticulos.DataSource = listadoArticulos;
            grdArticulos.Columns[0].Visible = false;
            grdArticulos.Columns[5].Visible = false;
        }

        private void OnArticuloAgregar(object sender, EventArgs e)
        {
            var resultado = new FrmArticulosAlta().ShowDialog();
            if (resultado == DialogResult.OK)
                _ActualizarGrilla();
        }

        private void OnArticuloModificar(object sender, EventArgs e)
        {
            var idArticulo = Convert.ToInt32(grdArticulos.SelectedRows[0].Cells[0].Value);
            var result = new FrmArticulosAlta() { IdArticulo = idArticulo }.ShowDialog();
            if (result == DialogResult.OK)
            {
                _ActualizarGrilla();
            }
        }

        private void OnArticuloEliminar(object sender, EventArgs e)
        {

        }

        private void OnArticuloSeleccionado(object sender, EventArgs e)
        {
            btnEliiminar.Enabled = true;
            btnModificar.Enabled = true;
        }
    }
}
