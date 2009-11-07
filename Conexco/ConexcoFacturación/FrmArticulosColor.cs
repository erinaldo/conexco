using System;
using System.Windows.Forms;

namespace ConexcoFacturación
{
    public partial class FrmArticulosColor : Form
    {
        public string NombreColorSeleccionado { get; set; }
        public string CodigoColorSeleccionado { get; set; }

        public FrmArticulosColor()
        {
            InitializeComponent();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            NombreColorSeleccionado = textBox1.Text;
            CodigoColorSeleccionado = textBox2.Text;
        }
    }
}
