using System;
using System.Windows.Forms;
using Conexco.Controller;

namespace ConexcoFacturación
{
    public partial class FrmArticulos : Form
    {
        public ArticulosController ArticulosController { get; set; }

        public FrmArticulos()
        {
            InitializeComponent();
        }

        private void FrmArticulosStock_Load(object sender, EventArgs e)
        {
            ArticulosController = new ArticulosController();
            _ActualizarGrilla();
        }

        private void _ActualizarGrilla()
        {
            var listadoArticulos = ArticulosController.ListarArticulos();
            grdArticulos.DataSource = listadoArticulos;
            grdArticulos.Columns[0].Visible = false;
            grdArticulos.Columns[5].Visible = false;

            grdArticulos.Columns[2].HeaderText = "Cód.Color";
            grdArticulos.Columns[3].HeaderText = "Descripción";

            grdArticulos.Columns[1].Width = 70;
            grdArticulos.Columns[2].Width = 70;
            grdArticulos.Columns[3].Width = 280;
            grdArticulos.Columns[4].Width = 100;
            grdArticulos.Columns[5].Width = 100;
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
            var result = new FrmArticulosAlta() { IdArticulo = idArticulo, Modificar = true}.ShowDialog();
            if (result == DialogResult.OK)
            {
                ArticulosController = new ArticulosController();
                _ActualizarGrilla();
            }
        }

        private void OnArticuloEliminar(object sender, EventArgs e)
        {
            var nombreArticulo = grdArticulos.SelectedRows[0].Cells[3].Value;
            var confirmacion = MessageBox.Show("Esta Seguro Desea Eliminar el Articulo: " + nombreArticulo + " ?", "Eliminar",
                                               MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    var idArticulo = Convert.ToInt32(grdArticulos.SelectedRows[0].Cells[0].Value);
                    if (ArticulosController.EliminarArticulo(idArticulo))
                    {
                        MessageBox.Show("Articulo eliminado satisfactoriamente");
                        ArticulosController = new ArticulosController();
                        _ActualizarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al guardar el articulo, inténtelo de nuevo");
                    }
                }
                catch(Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void OnArticuloSeleccionado(object sender, EventArgs e)
        {
            btnEliiminar.Enabled = grdArticulos.SelectedRows.Count > 0;
            btnModificar.Enabled = btnEliiminar.Enabled;     
        }
    }
}
