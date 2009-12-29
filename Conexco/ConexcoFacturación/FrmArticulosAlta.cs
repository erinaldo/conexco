using System;
using System.ComponentModel;
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

            _CargarComboColores();

            if (IdArticulo > 0)
            {
                Text = "Modificar Articulo";
                txtStock.Visible = false;
                lblStock.Visible = false;
                _CargarDatosArticulo();
            }
            else
                Text = "Agregar Articulo";

        }

        private void _CargarDatosArticulo()
        {
            var articulo = ArticulosController.DatosArticuloPorCodigo(IdArticulo);
            txtCodigo.Text = articulo.Codigo;
            txtDescripcion.Text = articulo.Descripcion;
            txtPrecio.Text = articulo.Precio.ToString();
            txtStock.Text = articulo.Stock.ToString();
            comboColor.SelectedValue = articulo.CodColor;
        }

        private void _CargarComboColores()
        {
            var listadoColores = ArticulosController.ListarColores();

            comboColor.ValueMember = "Codigo";
            comboColor.DisplayMember = "Descripcion";
            comboColor.DataSource = listadoColores.Tables[0];
        }

        private void OnCrearNuevoColor(object sender, EventArgs e)
        {
            var frmArticulosColor = new FrmArticulosColor();
            var resultado = frmArticulosColor.ShowDialog();
            _CargarComboColores();
        }

        private void OnCancelarAlta(object sender, EventArgs e)
        {
            Close();
        }

        private void OnGuardarArticulo(object sender, EventArgs e)
        {
            if (_FaltaCampoRequerido())
                return;

            var color = comboColor.SelectedValue ?? "0";
            var articuloGuardar = new Articulo
                                      {
                                          Codigo = txtCodigo.Text,
                                          Descripcion = txtDescripcion.Text,
                                          Precio = Convert.ToDecimal(txtPrecio.Text),
                                          CodColor = color.ToString(),
                                          Stock = Convert.ToDecimal(txtStock.Text),
                                    };

            try
            {
                if (Modificar)
                    articuloGuardar.idArticulo = IdArticulo;
                bool correcto = Modificar
                                    ? ArticulosController.ActualizarArticulo(articuloGuardar)
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
            catch(Exception)
            {
                MessageBox.Show("Ocurrio un error al guardar el artículo, verifique los datos");
                this.Close();
            }

        }

        private void CampoRequerido_Validating(object sender, CancelEventArgs e)
        {
            var control = (Control)sender;
            if (control.Text.Length == 0 || control.Text.Trim().StartsWith("-"))
            {
                errorProvider1.SetError(control, "Campo Requerido");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private bool _FaltaCampoRequerido()
        {
            bool error = false;

            if (String.IsNullOrEmpty(txtCodigo.Text))
                error = true;
            if (String.IsNullOrEmpty(txtDescripcion.Text))
                error = true;
            if (String.IsNullOrEmpty(txtPrecio.Text))
                error = true;
            if (String.IsNullOrEmpty(txtStock.Text))
                error = true;

            if (error)
                MessageBox.Show("Ingrese los campos requeridos");

            return error;
        }

        private void SoloNumerosDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == ',')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void SinGuion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
                e.Handled = true;
        }

    }
}
