using System;
using System.Windows.Forms;

namespace ConexcoFacturación
{
    public partial class FrmArticulosAlta : Form
    {
        public FrmArticulosAlta()
        {
            InitializeComponent();
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
        }
    }
}
