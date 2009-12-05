using System;
using System.Windows.Forms;
using Conexco.Controller;
using Conexco.Model;

namespace ConexcoFacturación
{
    public partial class FrmArticulosColor : Form
    {
        public string NombreColorSeleccionado { get; set; }
        public string CodigoColorSeleccionado { get; set; }
        public ArticulosController ArticulosController { get; set; }

        public FrmArticulosColor()
        {
            InitializeComponent();
            ArticulosController = new ArticulosController();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var colorNuevo = new Articulos_Color();

            NombreColorSeleccionado = txtNombreColor.Text;
            CodigoColorSeleccionado = txtCodColor.Text;


            colorNuevo.Codigo = txtCodColor.Text;
            colorNuevo.Descripcion = txtNombreColor.Text;
            colorNuevo.RGB = "";
            colorNuevo.R = 0;
            colorNuevo.G = 0;
            colorNuevo.B = 0;

            var resultado = ArticulosController.GuardarColor(colorNuevo);

            if (resultado)
            {
                MessageBox.Show("El color se ha guardado correctamente.");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Error al intentar guardar el color!");
        }

        private void SinGuion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
                e.Handled = true;
        }
    }
}
