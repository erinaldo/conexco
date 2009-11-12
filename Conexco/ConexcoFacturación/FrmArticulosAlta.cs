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

        }
    }
}
