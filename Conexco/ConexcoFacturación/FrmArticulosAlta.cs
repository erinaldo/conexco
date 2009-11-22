using System;
using System.Drawing;
using System.Windows.Forms;
using Conexco.Controller;
using Conexco.Model;
using Conexco.Utils;

namespace ConexcoFacturación
{
    public partial class FrmArticulosAlta : Form
    {
        public ArticulosController ArticulosController { get; set; }
        public int IdArticulo { get; set; }
        public bool Modificar { get; set; }

        public FrmArticulosAlta()
        {
            InitializeComponent();
        }

        private void FrmArticulosAlta_Load(object sender, EventArgs e)
        {
            ArticulosController = new ArticulosController();
            if (IdArticulo > 0)
            {
                Text = "Modificar Articulo";
                txtStock.Visible = false;
                errorStock.Visible = false;
                lblStock.Visible = false;
                _CargarDatosArticulo();
            }
            else
                Text = "Agregar Articulo";

            _CargarComboColores();
        }

        private void _CargarDatosArticulo()
        {
            var articulo = ArticulosController.DatosArticuloPorCodigo(IdArticulo);
            txtCodigo.Text = articulo.Codigo;
            txtDescripcion.Text = articulo.Descripcion;
            txtPrecio.Text = articulo.Precio.ToString();
            txtStock.Text = articulo.Stock.ToString();
        }

        private void _CargarComboColores()
        {
            var listadoColores = ArticulosController.ListarColores();

            foreach (var color in listadoColores)
            {
                color.RGB = String.Format("{0} - {1}", color.Codigo, color.Descripcion);
            }

            comboColor.DisplayMember = "RGB";
            comboColor.ValueMember = "Codigo";
            comboColor.DataSource = listadoColores;
        }

        private void OnCrearNuevoColor(object sender, EventArgs e)
        {
            var frmArticulosColor = new FrmArticulosColor();
            var resultado = frmArticulosColor.ShowDialog();
            if (resultado == DialogResult.OK)
                _CargarComboColores();
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

            var color = String.IsNullOrEmpty(comboColor.Text) ? "0" : comboColor.Text;
            var articuloGuardar = new Articulo
                                      {
                                          idArticulo = IdArticulo,
                                          Codigo = txtCodigo.Text,
                                          Descripcion = txtDescripcion.Text,
                                          Precio = Convert.ToDecimal(txtPrecio.Text),
                                          CodColor = color,
                                          Stock = Convert.ToDecimal(txtStock.Text),
                                    };

            bool correcto = Modificar ? ArticulosController.ActualizarArticulo(articuloGuardar) 
                                : ArticulosController.AgregarArticulo(articuloGuardar);

            if (correcto)
            {
                MessageBox.Show(Constants.OK_ALTA_ARTICULO);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(Constants.ERROR_ALTA_ARTICULO);
            }

        }
    }
}
