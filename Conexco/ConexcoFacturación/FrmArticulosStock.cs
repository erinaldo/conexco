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
    public partial class FrmArticulosStock : Form
    {
        public ArticulosController articulosController { get; set; }

        public FrmArticulosStock()
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
            grdArticulos.Columns[7].Visible = false;
        }

        private void OnArticuloAgregar(object sender, EventArgs e)
        {
            var resultado = new FrmArticulosAlta().ShowDialog();
        }

        private void OnArticuloModificar(object sender, EventArgs e)
        {

        }

        private void OnArticuloEliminar(object sender, EventArgs e)
        {

        }


    }
}
