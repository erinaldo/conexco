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
    public partial class FrmEmpresa : Form
    {
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void btnLocalidad_Click(object sender, EventArgs e)
        {
            var frmLocalidades = new FrmLocalidades();
            frmLocalidades.ShowDialog();
            txtLocalidad.Text = frmLocalidades.LocalidadSeleccionada;
            txtCodPostal.Text = frmLocalidades.CodPostalSeleccionado;
        }
    }
}
