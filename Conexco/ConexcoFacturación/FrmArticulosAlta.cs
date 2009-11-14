using System;
using System.Windows.Forms;
using Conexco.Controller;
using Conexco.Model;

namespace ConexcoFacturación
{
    public partial class FrmArticulosAlta : Form
    {
        public ArticulosController ArticulosController { get; set; }
        public int IdArticulo { get; set; }

        public FrmArticulosAlta()
        {
            InitializeComponent();
        }

        private void FrmArticulosAlta_Load(object sender, EventArgs e)
        {
            ArticulosController = new ArticulosController();
            if (IdArticulo > 0)
            {
                this.Text = "Modificar Articulo";
                _CargarDatosArticulo();
            }
            else
                this.Text = "Agregar Articulo";
        }

        private void _CargarDatosArticulo()
        {
            var articulo = ArticulosController.DatosArticuloPorCodigo(IdArticulo);
            txtCodigo.Text = articulo.Codigo;
            txtDescripcion.Text = articulo.Descripcion;
            txtPrecio.Text = articulo.Precio.ToString();
            txtStock.Text = articulo.Stock.ToString();
        }

        private void OnCrearNuevoColor(object sender, EventArgs e)
        {
            var frmArticulosColor = new FrmArticulosColor();
            var resultado = frmArticulosColor.ShowDialog();
            comboColor.Text = frmArticulosColor.CodigoColorSeleccionado;
        }

        private void OnCancelarAlta(object sender, EventArgs e)
        {
            Close();
        }

        private void OnGuardarArticulo(object sender, EventArgs e)
        {
            errorCodigo.Visible = String.IsNullOrEmpty(txtCodigo.Text);
            errorDescripcion.Visible = String.IsNullOrEmpty(txtDescripcion.Text);
            errorPrecio.Visible = String.IsNullOrEmpty(txtPrecio.Text);
            errorStock.Visible = String.IsNullOrEmpty(txtStock.Text);

            if (errorCodigo.Visible || errorDescripcion.Visible || errorPrecio.Visible || errorStock.Visible)
                return;

            var articuloGuardar = new Articulo()
                                      {
                                          Codigo = txtCodigo.Text,
                                          Descripcion = txtDescripcion.Text,
                                          Precio = Convert.ToDecimal(txtPrecio.Text),
                                          Stock = Convert.ToDecimal(txtStock.Text)
                                      };
            var correcto = ArticulosController.AgregarArticulo(articuloGuardar);

            if (correcto)
            {
                MessageBox.Show("Articulo guardado satisfactoriamente");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al guardar el articulo, intentelo de nuevo");
            }

        }

 
    }
}
