using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
